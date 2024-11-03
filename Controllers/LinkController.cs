using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ShortLinkC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinkController : ControllerBase
    {
        private static Dictionary<string, string> _links = new Dictionary<string, string>();

        // Endpoint para encurtar um link
        [HttpGet("shorten")]
        public ActionResult<string> Shorten(string originalUrl)
        {
            if (string.IsNullOrEmpty(originalUrl))
            {
                return BadRequest("O parâmetro originalUrl é obrigatório.");
            }

            // Gera um "slug" simples para o link encurtado
            string shortKey = GenerateShortKey(originalUrl);
            _links[shortKey] = originalUrl;

            // Retorna o link encurtado como HTML para ser exibido na página
            return Ok($"Link encurtado: <a href=\"/api/link/{shortKey}\">http://localhost:5093/api/link/{shortKey}</a>");
        }

        // Endpoint para redirecionar
        [HttpGet("{shortKey}")]
        public IActionResult RedirectToOriginal(string shortKey)
        {
            if (_links.TryGetValue(shortKey, out var originalUrl))
            {
                return Redirect(originalUrl);
            }

            return NotFound("Link não encontrado.");
        }

        private string GenerateShortKey(string originalUrl)
        {
            return originalUrl.GetHashCode().ToString("x"); // Exemplo simples
        }
    }
}
