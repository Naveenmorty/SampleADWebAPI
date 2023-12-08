using SampleADWebApi.Service.Models;

namespace SampleADWebApi.Service
{
    public class Data
    {
        public static List<NameModel> namelist = new List<NameModel>
        {
            new NameModel{firstname = "Test1", lastname = "Last1" },
            new NameModel{firstname = "Test2", lastname = "Last2" }
        };
    }
}
