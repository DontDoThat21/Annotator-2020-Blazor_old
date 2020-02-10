using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anno
{
    /// <summary>
    /// We set the global variable "array1" to the CUNOs from the below web method call.
    /// We then set the global variable "array2" to the Client Descriptions from the below web method call.
    /// </summary>
    public class GetInventoryByClient
    {
        public GetInventoryClientList.GetClientListResponse responseGlobal;

        public GetInventoryByClient()
        {
            Response();
        }
        
        public void Response()
        {
            GetInventoryClientList.GetInventoryClientListSoapClient client =
                new GetInventoryClientList.GetInventoryClientListSoapClient(0);
            //responseGlobal = await client.GetClientListAsync(0);
            responseGlobal = client.GetClientListAsync(0).Result;

            List<string> tempCunos = new List<string>();
            List<string> tempDescs = new List<string>();
            for (int i = 0; i < responseGlobal.Body.GetClientListResult.Split("^").Length; i++)  
            {
                var arr = responseGlobal.Body.GetClientListResult.Split("^")[i].Split("|"); // Array of cuno numbers and cuno descriptions.
                tempCunos.Add(arr[0]);
                tempDescs.Add(arr[1]);
            }
            Startup.array1 = tempCunos.ToArray();
            Startup.array2 = tempDescs.ToArray();

            //Startup.array1 = responseGlobal.Body.GetClientListResult.Split("^");
        }
    }
}
