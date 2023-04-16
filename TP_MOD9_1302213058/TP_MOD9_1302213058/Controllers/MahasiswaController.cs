using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TP_MOD9_1302213058.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa{Nama = "Mochamad Rizky Evan Ramadhan", Nim = "1302213058"},
            new Mahasiswa{Nama = "Kamal Maula Azka Shidqi", Nim = "1302210032"},
            new Mahasiswa{Nama = "Herdi Ardana", Nim = "1302210078"},
            new Mahasiswa{Nama = "Iqnaj Nadhif", Nim = "1302210104"},
            new Mahasiswa{Nama = "Maman Ar rasyid", Nim = "1302213088"}
        };

        [HttpGet]
        //membuat output list array dari objek mahasiswa di atas
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }

        [HttpPost]
        //membuat objek mahasiswa baru dan menambahkan objek menyertai nama dan nim yang sudah di buat di class Mahasiswa dengan menggunakan setter getter
        public void Post([FromBody] Mahasiswa newmahasiswa)
        {
            mahasiswa.Add(newmahasiswa);
        }
        [HttpGet("index")]
        //memanggil 1 objek mahasiswa menggunakan index array
        public Mahasiswa Get(int index)
        {
            return mahasiswa[index];
        }

        [HttpDelete("index")]
        //menghapus objek mahasiswa sesuai dengan array list nya
        public void Delete(int index)
        {
            mahasiswa.RemoveAt(index);
        }
    }

    
}
