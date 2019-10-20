using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IO;
using bankocr;

namespace bankocr.service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OcrController : ControllerBase
    {
        // POST api/ocr
        [HttpPost]
        public IActionResult Post([FromForm] IFormFile file)
        {
            using (var fileStream = new StreamReader(file.OpenReadStream()))
            {
                string fileContent = fileStream.ReadToEnd();

                AccountNumberScanner accountNumberScanner = new AccountNumberScanner();
                string result = accountNumberScanner.Scan(fileContent);

                return Ok(new { status = true, message = result});
            }
        }
    }
}
