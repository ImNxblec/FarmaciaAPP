using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace FarmaciaAPP.Servicios
{
    internal class OpenAI
    {
        private static readonly string apiKey = "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"; // Clave API de OpenAI

        public static async Task<string> ConsultarOpenAi(string pregunta)
        {
            string openAiUrl = "https://api.openai.com/v1/chat/completions";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

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

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(openAiUrl, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
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
