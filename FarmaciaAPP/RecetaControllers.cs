using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FarmaciaAPP.Clases
{
    public class OpenAI
    {
        private static readonly string apiKey = "tu-clave-de-api-aquí"; // Clave de API única para OpenAI.

        public static async Task<string> ConsultarOpenAi(string pregunta)
        {
            string openAiUrl = "https://api.openai.com/v1/chat/completions";

            using (var client = new HttpClient())
            {
                // Agregar encabezado de autorización con la clave API.
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                // Crear el cuerpo de la solicitud.
                var requestBody = new
                {
                    model = "gpt-3.5-turbo",
                    messages = new[]
                    {
                        new { role = "system", content = "Eres un asistente útil para responder preguntas sobre medicamentos." },
                        new { role = "user", content = pregunta }
                    },
                    max_tokens = 100,
                    temperature = 0.5
                };

                // Serializar el cuerpo a JSON.
                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Enviar la solicitud POST.
                var response = await client.PostAsync(openAiUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    // Deserializar la respuesta y devolver el contenido del mensaje.
                    dynamic result = JsonConvert.DeserializeObject(responseString);
                    return result.choices[0].message.content.ToString();
                }
                else
                {
                    throw new Exception("Error al llamar a la API de OpenAI: " + responseString);
                }
            }
        }
    }
}


