using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tpmod10_103022300085.Models;

namespace tpmod10_103022300085.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Devon Arya Daniswara", Nim = "103022300085" },
            new Mahasiswa { Nama = "Subhan Maulana Ahmad", Nim = "103022300081" },
            new Mahasiswa { Nama = "Aslam", Nim = "103022330152" },
            new Mahasiswa { Nama = "Haikal Cannavaro", Nim = "103022300106" }
        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa(Mahasiswa mahasiswaBaru)
        {
            daftarMahasiswa.Add(mahasiswaBaru);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
