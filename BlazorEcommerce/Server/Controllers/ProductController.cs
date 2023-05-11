using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
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
                Title = "The Adventures of Sherlock Holmes",
                Description = "	The King of Bohemia engages Holmes to recover an indiscreet photograph showing him with the renowned beauty, adventuress and opera singer Irene Adler‍—‌the revelation of which would derail his marriage to a daughter of the King of Scandinavia. In disguise, Holmes witnesses Adler marry the man she truly loves, then by means of an elaborate stratagem discovers the photograph's hiding place. But when Holmes and the king return to retrieve the photo, they find Adler has fled the country with it, leaving behind a letter for Holmes and a portrait of herself for the King. The king allows Holmes to retain the portrait as a souvenir.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b9/Adventures_of_sherlock_holmes.jpg?20110613160600",
                Price = 29.99m
            },
            new Product
            {
                Id = 2,
                Title = "Ready Player One",
                Description = "Teenager Wade Watts lives with his aunt in Oklahoma City[10] in the 'stacks, a poverty-stricken district constructed of trailer homes piled on top of each other. He spends his spare time as a 'gunter' ('egg hunter'), logging on to the OASIS as an avatar under the moniker Parzival, reading Halliday's journal Anorak's Almanac, and researching details of the 1980s pop culture, mainly classic video games and movies, that Halliday loved. One day, he realizes that the first key is located on Ludus, the same virtual world as his own online high school, in a re-creation of the Dungeons & Dragons module Tomb of Horrors. He meets Art3mis, a famous female gunter and blogger, and advances further than she does when he defeats the AI Acererak at the video game Joust. He is awarded the Copper Key, and appears on the 'Scoreboard', attracting the world's attention.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                Price = 9.99m
            },
           new Product
            {
                Id = 3,
                Title = "Harry Potter and the Philosopher's Stone",
                Description = "Harry Potter lives with his abusive aunt and uncle, Vernon and Petunia Dursley, and their bullying son, Dudley. On Harry's eleventh birthday, a half-giant named Rubeus Hagrid personally delivers an acceptance letter to Hogwarts School of Witchcraft and Wizardry, revealing that Harry's parents, James and Lily Potter, were wizards. When Harry was one year old, an evil and powerful dark wizard, Lord Voldemort, murdered his parents. Harry survived Voldemort's killing curse that rebounded and seemingly destroyed the Dark Lord, leaving a lightning bolt-shaped scar on his forehead. Unknown to Harry, this act made him famous in the wizarding world.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg",
                Price = 12.99m
            },
        };

        [HttpGet]
        public async Task<IActionResult> GetResult()
        {
            return Ok(Products);
        }
    }
}
