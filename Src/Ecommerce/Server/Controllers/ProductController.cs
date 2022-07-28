using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99M
            },
            new Product
            {
                Id = 2,
                Title = "Sholay",
                Description = "Sholay (Hindustani: [ˈʃoːleː] (listen), transl. Embers) is a 1975 Indian Hindi-language action-adventure film written by Salim–Javed, directed by Ramesh Sippy, and produced by his father G. P. Sippy. The film is about two criminals, Veeru (Dharmendra) and Jai (Amitabh Bachchan), hired by a retired police officer (Sanjeev Kumar) to capture the ruthless dacoit Gabbar Singh (Amjad Khan). Hema Malini and Jaya Bhaduri also star, as Veeru and Jai's love interests, Basanti and Radha, respectively. Sholay is considered a classic and one of the best Indian films. It was ranked first in the British Film Institute's 2002 poll of 'Top 10 Indian Films' of all time. In 2005, the judges of the 50th Filmfare Awards named it the Best Film of 50 Years. ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Sholay-poster.jpg/220px-Sholay-poster.jpg",
                Price = 19.99M
            },
            new Product
            {
                Id = 3,
                Title = "Manichitrathazhu",
                Description = "Manichitrathazhu (transl. The Ornate Lock) is a 1993 Indian Malayalam-language epic psychological horror film directed by Fazil, written by Madhu Muttam, and produced by Swargachitra Appachan.[1] The film stars Mohanlal, Suresh Gopi and Shobana with Nedumudi Venu, Innocent, Vinaya Prasad, K. P. A. C. Lalitha, Sridhar, K. B. Ganesh Kumar, Sudheesh, and Thilakan in supporting roles.[2] The story is inspired by a tragedy that happened in the Alummoottil tharavad, a central Travancore family, in the 19th century",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/43/Manichitrathazhu.jpg",
                Price = 19.99M
            }
        };

		[HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
		{
            return Ok(Products);
		}
    }
}
