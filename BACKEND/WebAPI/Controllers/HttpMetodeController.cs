using System.Text;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")] //ruta ce se javiti na /api/v1/httpMetode
    public class HttpMetodeController : ControllerBase
    {

        //ruta je METODA
        //Ovdje pocinje ruta

        //ovo jos nije ruta sve dok se ne kaze ovo:
        [HttpGet]
        public string HelloWorld()
        {
            return "hello";
        }


        //Ovdje zavrsava ruta

        //ovdje pocinje ruta
        [HttpGet]
        [Route("Pozdrav")]
        public string HelloWorld(string ime)
        {
            return new StringBuilder().Append("Hello").Append(ime).ToString();
        }


        //ovdje zavrsava ruta


        [HttpGet]
        [Route("json")]
        public IActionResult Json()
        {
            //metoda OK je dosla iz nadklase
            //ovo nije klasa
            return Ok(new { Ime = "Pero", Prezime = "Peric" }); //ovo nije OOP
        }


        [HttpPost]
        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello " + osoba.Ime;
            //ovdje ce ici spremanje u bazu
            return StatusCode(StatusCodes.Status201Created, osoba);
        }

        [HttpPut]
        public IActionResult Put(Osoba o)
        {
            o.Ime = "Promjenio " + o.Ime;
            return Ok(o);
        }



        [HttpDelete]

        public IActionResult Delete(int sifra)
        {
            if(sifra <= 0)
            {
                return BadRequest(new { poruka = "Sifra mora biti veca od 0" });
            }
            return NoContent();//uspjesno si obrisao, nema vise sadrzaja, pokaze 204
        }




    }
}
