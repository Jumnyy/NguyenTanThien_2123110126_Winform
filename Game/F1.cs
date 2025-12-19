using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using WMPLib;
using System.IO;

namespace Game
{
    public partial class F1 : Form
    {
        enum GameState { Home, Playing, GameOver }
        GameState currentState = GameState.Home;

        Timer gameTimer;
        WindowsMediaPlayer bgmPlayer;

        PictureBox pbBoom, pbPlayer;
        Label lbScore;
        Button btStart, btExit, btHome;

        Random rd = new Random();

        int boomX, boomY;
        int boomSpeed;
        int playerSpeed = 18;
        int score = 0;

        Image bgHomeImg, bgGameImg, boomImg, playerImg;
        SoundPlayer hitSound, gameOverSound;

        public F1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += F1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ===== LOAD IMAGES =====
            bgHomeImg = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "1719718.gif"));
            bgGameImg = bgHomeImg; // dùng chung, muốn khác thì đổi ảnh
            boomImg = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "bay.png"));
            playerImg = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "bed.png"));

            // ===== LOAD SOUNDS =====
            hitSound = new SoundPlayer(Path.Combine(Application.StartupPath, "Sounds", "hit.wav"));
            gameOverSound = new SoundPlayer(Path.Combine(Application.StartupPath, "Sounds", "gameover.wav"));

            // ===== BGM =====
            bgmPlayer = new WindowsMediaPlayer();
            bgmPlayer.settings.setMode("loop", true);
            bgmPlayer.settings.volume = 50;

            ShowHome();
        }

        // ================= BGM =================
        void PlayBGM(string file)
        {
            bgmPlayer.controls.stop();
            bgmPlayer.URL = Path.Combine(Application.StartupPath, "Sounds", file);
            bgmPlayer.controls.play();
        }

        // ================= HOME =================
        void ShowHome()
        {
            currentState = GameState.Home;
            Controls.Clear();

            BackgroundImage = bgHomeImg;
            BackgroundImageLayout = ImageLayout.Stretch;

            PlayBGM("home.mp3");

            Label title = new Label
            {
                Text = "BUỒN NGỦ ZZZ",
                Font = new Font("Arial", 28, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(ClientSize.Width / 2 - 140, 120)
            };

            btStart = new Button
            {
                Text = "START",
                Size = new Size(200, 50),
                Location = new Point(ClientSize.Width / 2 - 100, 220)
            };
            btStart.Click += (s, e) => StartGame();

            btExit = new Button
            {
                Text = "EXIT",
                Size = new Size(200, 50),
                Location = new Point(ClientSize.Width / 2 - 100, 290)
            };
            btExit.Click += (s, e) => Close();

            Controls.Add(title);
            Controls.Add(btStart);
            Controls.Add(btExit);
        }

        // ================= START GAME =================
        void StartGame()
        {
            currentState = GameState.Playing;
            Controls.Clear();
            score = 0;

            BackgroundImage = bgGameImg;
            BackgroundImageLayout = ImageLayout.Stretch;

            PlayBGM("game.mp3");

            pbPlayer = new PictureBox
            {
                Size = new Size(100, 70),
                Image = playerImg,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Location = new Point(ClientSize.Width / 2 - 50, ClientSize.Height - 160)
            };
            Controls.Add(pbPlayer);

            pbBoom = new PictureBox
            {
                Size = new Size(80, 80),
                Image = boomImg,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
            Controls.Add(pbBoom);
            ResetBoom();

            lbScore = new Label
            {
                Text = "Score: 0",
                Font = new Font("Arial", 14, FontStyle.Bold),
                ForeColor = Color.Yellow,
                BackColor = Color.Transparent,
                Location = new Point(10, 10)
            };
            Controls.Add(lbScore);

            gameTimer = new Timer { Interval = 20 };
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();
        }

        // ================= GAME LOOP =================
        void GameTimer_Tick(object sender, EventArgs e)
        {
            boomY += boomSpeed;
            pbBoom.Location = new Point(boomX, boomY);

            if (pbBoom.Bounds.IntersectsWith(pbPlayer.Bounds))
            {
                hitSound.Play();
                score++;
                lbScore.Text = $"Score: {score}";
                ResetBoom();
            }

            if (boomY > ClientSize.Height)
                EndGame();
        }

        void ResetBoom()
        {
            boomX = rd.Next(0, ClientSize.Width - pbBoom.Width);
            boomY = -pbBoom.Height;

            int level = score / 5;
            boomSpeed = Math.Min(3 + level, 15);
        }

        // ================= GAME OVER =================
        void EndGame()
        {
            currentState = GameState.GameOver;
            gameTimer.Stop();

            bgmPlayer.controls.stop();
            gameOverSound.Play();

            Controls.Clear();

            BackgroundImage = bgHomeImg;
            BackgroundImageLayout = ImageLayout.Stretch;

            Label lbOver = new Label
            {
                Text = $"GAME OVER\nScore: {score}",
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(ClientSize.Width / 2 - 130, 150)
            };

            btHome = new Button
            {
                Text = "HOME",
                Size = new Size(200, 50),
                Location = new Point(ClientSize.Width / 2 - 100, 260)
            };
            btHome.Click += (s, e) => ShowHome();

            Controls.Add(lbOver);
            Controls.Add(btHome);
        }

        // ================= KEYBOARD =================
        void F1_KeyDown(object sender, KeyEventArgs e)
        {
            if (currentState != GameState.Playing) return;

            if (e.KeyCode == Keys.Left && pbPlayer.Left > 0)
                pbPlayer.Left -= playerSpeed;

            if (e.KeyCode == Keys.Right && pbPlayer.Right < ClientSize.Width)
                pbPlayer.Left += playerSpeed;
        }
    }
}
