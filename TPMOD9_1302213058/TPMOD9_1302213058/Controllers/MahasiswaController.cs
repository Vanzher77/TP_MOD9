using Microsoft.AspNetCore.Mvc;

namespace TPMOD9_1302213058.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa(){Nama = "Mochamad Rizky Evan Ramadhan", Nim = "1302213058"}
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> GET()
        {
            return mahasiswa;
        }
    }
}