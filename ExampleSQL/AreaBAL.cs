using System.Collections.Generic;

namespace ExampleSQL
{
    public class AreaBAL
    {
        AreaDAL dal = new AreaDAL();

        public List<AreaBEL> ReadAreaList()
        {
            return dal.ReadAreaList();
        }
    }
}