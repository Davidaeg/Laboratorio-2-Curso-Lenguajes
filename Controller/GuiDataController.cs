using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Lab2DavidAlvarado.Controller
{
    class GuiDataController
    {
        public bool CheckTextBox(string name, string lastName, string age, string id, string email, string pass, string passConf)
        {
            bool answer = true;
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(passConf) || string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(age))
                answer = false;



            return answer;
        }//CheckTextBox

        public bool CheckEmailAddress(string email)
        {
            bool answer = false;
            string accessKey = "108099c000856756f5dcb85c094a38c2";

            var client = new HttpClient(); //Crea el Cliente HTTP
            string urlParameters = "?access_key=" + accessKey + "&email=" + email; //Parametros a enviar
            client.BaseAddress = new Uri("http://apilayer.net/api/check");//el URI que usa el cliente

            // Se aagrega un encabezado para el JSON
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Task<HttpResponseMessage> responseTask = client.GetAsync(urlParameters); // Se hace la consulta 

            responseTask.Wait(); //Espera a que se termine completamente, Just in case

            HttpResponseMessage httpResponse = responseTask.Result; //se obtiene la respuesta

            //Comprueba si fue exitosa la consulta
            if (httpResponse.IsSuccessStatusCode)
            {
                //Extra el string de la respuesta
                Task<string> messageTask = httpResponse.Content.ReadAsStringAsync();
                messageTask.Wait();
                string responseMessage = messageTask.Result; //obtiene el JSON como string
                //MessageBox.Show(responseMessage);
                //captura el Json con formato e ignora los campos Null
                var deserializeSettings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                };
                //Crea objeto con la respuesta para manipular la info
                JsonMailResponse mbl_answer = JsonConvert.DeserializeObject<JsonMailResponse>(responseMessage, deserializeSettings);
                //MessageBox.Show(mbl_answer.DidYouMean);
                if (mbl_answer.SmtpCheck == true & string.IsNullOrEmpty(mbl_answer.DidYouMean))
                {
                    answer = true;
                }

            }

            return answer;
        }// CheckEmailAddress


    }
}
