using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CIDM3312_Final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Hunters.Any())
                {
                    return;
                }
                List<Hunter> hunters = new List<Hunter> {
                    new Hunter {Name = "NotWolf",  HRank = 152, MRank = 132, TDmg = 180000},
                    new Hunter {Name = "NoaH",  HRank = 350, MRank = 300, TDmg = 180000},
                    new Hunter {Name = "Leana",  HRank = 806, MRank = 648, TDmg = 180000},
                    new Hunter {Name = "Akaviria",  HRank = 159, MRank = 133, TDmg = 180000},
                    new Hunter {Name = "FiteNite",  HRank = 41, MRank = 39, TDmg = 180000}
                };
                context.AddRange(hunters);

                List<Hunt> hunts = new List<Hunt> {
                    new Hunt {Monster = "Banbaro", H1Name = "NotWolf", H1Dmg = 7500, H2Name = "NoaH", H2Dmg = 7500, H3Name = "Leana", H3Dmg = 7500, H4Name = "Akaviria", H4Dmg = 7500,},
                    new Hunt {Monster = "Dodogama", H1Name = "FiteNite", H1Dmg = 7500, H2Name = "NotWolf", H2Dmg = 7500, H3Name = "NoaH", H3Dmg = 7500, H4Name = "Leana", H4Dmg = 7500,},
                    new Hunt {Monster = "Ebony Odagaran", H1Name = "Akaviria", H1Dmg = 7500, H2Name = "FiteNite", H2Dmg = 7500, H3Name = "NotWolf", H3Dmg = 7500, H4Name = "NoaH", H4Dmg = 7500,},
                    new Hunt {Monster = "Silver Rathalos", H1Name = "Leana", H1Dmg = 7500, H2Name = "Akaviria", H2Dmg = 7500, H3Name = "FiteNite", H3Dmg = 7500, H4Name = "NotWolf", H4Dmg = 7500,},
                    new Hunt {Monster = "Nargacuga", H1Name = "NoaH", H1Dmg = 7500, H2Name = "Leana", H2Dmg = 7500, H3Name = "Akaviria", H3Dmg = 7500, H4Name = "FiteNite", H4Dmg = 7500,},
                    new Hunt {Monster = "Bazelgeuse", H1Name = "NotWolf", H1Dmg = 7500, H2Name = "NoaH", H2Dmg = 7500, H3Name = "Leana", H3Dmg = 7500, H4Name = "Akaviria", H4Dmg = 7500,},
                    new Hunt {Monster = "Great Jagras", H1Name = "FiteNite", H1Dmg = 7500, H2Name = "NotWolf", H2Dmg = 7500, H3Name = "NoaH", H3Dmg = 7500, H4Name = "Leana", H4Dmg = 7500,},
                    new Hunt {Monster = "Paolumu", H1Name = "Akaviria", H1Dmg = 7500, H2Name = "FiteNite", H2Dmg = 7500, H3Name = "NotWolf", H3Dmg = 7500, H4Name = "NoaH", H4Dmg = 7500,},
                    new Hunt {Monster = "Velkhana", H1Name = "Leana", H1Dmg = 7500, H2Name = "Akaviria", H2Dmg = 7500, H3Name = "FiteNite", H3Dmg = 7500, H4Name = "NotWolf", H4Dmg = 7500,},
                    new Hunt {Monster = "Tigrex", H1Name = "NoaH", H1Dmg = 7500, H2Name = "Leana", H2Dmg = 7500, H3Name = "Akaviria", H3Dmg = 7500, H4Name = "FiteNite", H4Dmg = 7500,},
                    new Hunt {Monster = "Kushala Daora", H1Name = "NotWolf", H1Dmg = 7500, H2Name = "NoaH", H2Dmg = 7500, H3Name = "Leana", H3Dmg = 7500, H4Name = "Akaviria", H4Dmg = 7500,},
                    new Hunt {Monster = "Kirin", H1Name = "FiteNite", H1Dmg = 7500, H2Name = "NotWolf", H2Dmg = 7500, H3Name = "NoaH", H3Dmg = 7500, H4Name = "Leana", H4Dmg = 7500,},
                    new Hunt {Monster = "Leshen", H1Name = "Akaviria", H1Dmg = 7500, H2Name = "FiteNite", H2Dmg = 7500, H3Name = "NotWolf", H3Dmg = 7500, H4Name = "NoaH", H4Dmg = 7500,},
                    new Hunt {Monster = "Kushala Daora", H1Name = "Leana", H1Dmg = 7500, H2Name = "Akaviria", H2Dmg = 7500, H3Name = "FiteNite", H3Dmg = 7500, H4Name = "NotWolf", H4Dmg = 7500,},
                    new Hunt {Monster = "Rathian", H1Name = "NoaH", H1Dmg = 7500, H2Name = "Leana", H2Dmg = 7500, H3Name = "Akaviria", H3Dmg = 7500, H4Name = "FiteNite", H4Dmg = 7500,},
                    new Hunt {Monster = "Beotodus", H1Name = "NotWolf", H1Dmg = 7500, H2Name = "NoaH", H2Dmg = 7500, H3Name = "Leana", H3Dmg = 7500, H4Name = "Akaviria", H4Dmg = 7500,},
                    new Hunt {Monster = "Legiana", H1Name = "FiteNite", H1Dmg = 7500, H2Name = "NotWolf", H2Dmg = 7500, H3Name = "NoaH", H3Dmg = 7500, H4Name = "Leana", H4Dmg = 7500,},
                    new Hunt {Monster = "Lavasioth", H1Name = "Akaviria", H1Dmg = 7500, H2Name = "FiteNite", H2Dmg = 7500, H3Name = "NotWolf", H3Dmg = 7500, H4Name = "NoaH", H4Dmg = 7500,},
                    new Hunt {Monster = "Brachydios", H1Name = "Leana", H1Dmg = 7500, H2Name = "Akaviria", H2Dmg = 7500, H3Name = "FiteNite", H3Dmg = 7500, H4Name = "NotWolf", H4Dmg = 7500,},
                    new Hunt {Monster = "Namielle", H1Name = "NoaH", H1Dmg = 7500, H2Name = "Leana", H2Dmg = 7500, H3Name = "Akaviria", H3Dmg = 7500, H4Name = "FiteNite", H4Dmg = 7500,},
                    new Hunt {Monster = "Kulve Taroth", H1Name = "NotWolf", H1Dmg = 7500, H2Name = "NoaH", H2Dmg = 7500, H3Name = "Leana", H3Dmg = 7500, H4Name = "Akaviria", H4Dmg = 7500,},
                    new Hunt {Monster = "Rathalos", H1Name = "FiteNite", H1Dmg = 7500, H2Name = "NotWolf", H2Dmg = 7500, H3Name = "NoaH", H3Dmg = 7500, H4Name = "Leana", H4Dmg = 7500,},
                    new Hunt {Monster = "Rathalos", H1Name = "Akaviria", H1Dmg = 7500, H2Name = "FiteNite", H2Dmg = 7500, H3Name = "NotWolf", H3Dmg = 7500, H4Name = "NoaH", H4Dmg = 7500,},
                    new Hunt {Monster = "Nergigante", H1Name = "Leana", H1Dmg = 7500, H2Name = "Akaviria", H2Dmg = 7500, H3Name = "FiteNite", H3Dmg = 7500, H4Name = "NotWolf", H4Dmg = 7500,},
                    new Hunt {Monster = "TziTzi-Ya-Ku", H1Name = "NoaH", H1Dmg = 7500, H2Name = "Leana", H2Dmg = 7500, H3Name = "Akaviria", H3Dmg = 7500, H4Name = "FiteNite", H4Dmg = 7500,},
                    new Hunt {Monster = "Alatreon", H1Name = "NotWolf", H1Dmg = 7500, H2Name = "NoaH", H2Dmg = 7500, H3Name = "Leana", H3Dmg = 7500, H4Name = "Akaviria", H4Dmg = 7500,},
                    new Hunt {Monster = "Great Jagras", H1Name = "FiteNite", H1Dmg = 7500, H2Name = "NotWolf", H2Dmg = 7500, H3Name = "NoaH", H3Dmg = 7500, H4Name = "Leana", H4Dmg = 7500,},
                    new Hunt {Monster = "Tobi-Kadachi", H1Name = "Akaviria", H1Dmg = 7500, H2Name = "FiteNite", H2Dmg = 7500, H3Name = "NotWolf", H3Dmg = 7500, H4Name = "NoaH", H4Dmg = 7500,},
                    new Hunt {Monster = "Great Girros", H1Name = "Leana", H1Dmg = 7500, H2Name = "Akaviria", H2Dmg = 7500, H3Name = "FiteNite", H3Dmg = 7500, H4Name = "NotWolf", H4Dmg = 7500,},
                    new Hunt {Monster = "Pukei-Pukei", H1Name = "NoaH", H1Dmg = 7500, H2Name = "Leana", H2Dmg = 7500, H3Name = "Akaviria", H3Dmg = 7500, H4Name = "FiteNite", H4Dmg = 7500,},
                };
                context.AddRange(hunts);
                context.SaveChanges();

                 List<HuntersHunt> hdmg = new List<HuntersHunt> {
                    new HuntersHunt {HunterID = 1, HuntID = 1},
                    new HuntersHunt {HunterID = 1, HuntID = 2},
                    new HuntersHunt {HunterID = 1, HuntID = 3},
                    new HuntersHunt {HunterID = 1, HuntID = 4},
                    new HuntersHunt {HunterID = 1, HuntID = 6},
                    new HuntersHunt {HunterID = 1, HuntID = 7},
                    new HuntersHunt {HunterID = 1, HuntID = 8},
                    new HuntersHunt {HunterID = 1, HuntID = 9},
                    new HuntersHunt {HunterID = 1, HuntID = 11},
                    new HuntersHunt {HunterID = 1, HuntID = 12},
                    new HuntersHunt {HunterID = 1, HuntID = 13},
                    new HuntersHunt {HunterID = 1, HuntID = 14},
                    new HuntersHunt {HunterID = 1, HuntID = 16},
                    new HuntersHunt {HunterID = 1, HuntID = 17},
                    new HuntersHunt {HunterID = 1, HuntID = 18},
                    new HuntersHunt {HunterID = 1, HuntID = 19},
                    new HuntersHunt {HunterID = 1, HuntID = 21},
                    new HuntersHunt {HunterID = 1, HuntID = 22},
                    new HuntersHunt {HunterID = 1, HuntID = 23},
                    new HuntersHunt {HunterID = 1, HuntID = 24},
                    new HuntersHunt {HunterID = 1, HuntID = 26},
                    new HuntersHunt {HunterID = 1, HuntID = 27},
                    new HuntersHunt {HunterID = 1, HuntID = 28},
                    new HuntersHunt {HunterID = 1, HuntID = 29},

                    new HuntersHunt {HunterID = 2, HuntID = 1},
                    new HuntersHunt {HunterID = 2, HuntID = 2},
                    new HuntersHunt {HunterID = 2, HuntID = 3},
                    new HuntersHunt {HunterID = 2, HuntID = 5},
                    new HuntersHunt {HunterID = 2, HuntID = 6},
                    new HuntersHunt {HunterID = 2, HuntID = 7},
                    new HuntersHunt {HunterID = 2, HuntID = 8},
                    new HuntersHunt {HunterID = 2, HuntID = 10},
                    new HuntersHunt {HunterID = 2, HuntID = 11},
                    new HuntersHunt {HunterID = 2, HuntID = 12},
                    new HuntersHunt {HunterID = 2, HuntID = 13},
                    new HuntersHunt {HunterID = 2, HuntID = 15},
                    new HuntersHunt {HunterID = 2, HuntID = 16},
                    new HuntersHunt {HunterID = 2, HuntID = 17},
                    new HuntersHunt {HunterID = 2, HuntID = 18},
                    new HuntersHunt {HunterID = 2, HuntID = 20},
                    new HuntersHunt {HunterID = 2, HuntID = 21},
                    new HuntersHunt {HunterID = 2, HuntID = 22},
                    new HuntersHunt {HunterID = 2, HuntID = 23},
                    new HuntersHunt {HunterID = 2, HuntID = 25},
                    new HuntersHunt {HunterID = 2, HuntID = 26},
                    new HuntersHunt {HunterID = 2, HuntID = 27},
                    new HuntersHunt {HunterID = 2, HuntID = 28},
                    new HuntersHunt {HunterID = 2, HuntID = 30},

                    new HuntersHunt {HunterID = 3, HuntID = 1},
                    new HuntersHunt {HunterID = 3, HuntID = 2},
                    new HuntersHunt {HunterID = 3, HuntID = 4},
                    new HuntersHunt {HunterID = 3, HuntID = 5},
                    new HuntersHunt {HunterID = 3, HuntID = 6},
                    new HuntersHunt {HunterID = 3, HuntID = 7},
                    new HuntersHunt {HunterID = 3, HuntID = 9},
                    new HuntersHunt {HunterID = 3, HuntID = 10},
                    new HuntersHunt {HunterID = 3, HuntID = 11},
                    new HuntersHunt {HunterID = 3, HuntID = 12},
                    new HuntersHunt {HunterID = 3, HuntID = 14},
                    new HuntersHunt {HunterID = 3, HuntID = 15},
                    new HuntersHunt {HunterID = 3, HuntID = 16},
                    new HuntersHunt {HunterID = 3, HuntID = 17},
                    new HuntersHunt {HunterID = 3, HuntID = 19},
                    new HuntersHunt {HunterID = 3, HuntID = 20},
                    new HuntersHunt {HunterID = 3, HuntID = 21},
                    new HuntersHunt {HunterID = 3, HuntID = 22},
                    new HuntersHunt {HunterID = 3, HuntID = 24},
                    new HuntersHunt {HunterID = 3, HuntID = 25},
                    new HuntersHunt {HunterID = 3, HuntID = 26},
                    new HuntersHunt {HunterID = 3, HuntID = 27},
                    new HuntersHunt {HunterID = 3, HuntID = 29},
                    new HuntersHunt {HunterID = 3, HuntID = 30},

                    new HuntersHunt {HunterID = 4, HuntID = 1},
                    new HuntersHunt {HunterID = 4, HuntID = 3},
                    new HuntersHunt {HunterID = 4, HuntID = 4},
                    new HuntersHunt {HunterID = 4, HuntID = 5},
                    new HuntersHunt {HunterID = 4, HuntID = 6},
                    new HuntersHunt {HunterID = 4, HuntID = 8},
                    new HuntersHunt {HunterID = 4, HuntID = 9},
                    new HuntersHunt {HunterID = 4, HuntID = 10},
                    new HuntersHunt {HunterID = 4, HuntID = 11},
                    new HuntersHunt {HunterID = 4, HuntID = 13},
                    new HuntersHunt {HunterID = 4, HuntID = 14},
                    new HuntersHunt {HunterID = 4, HuntID = 15},
                    new HuntersHunt {HunterID = 4, HuntID = 16},
                    new HuntersHunt {HunterID = 4, HuntID = 18},
                    new HuntersHunt {HunterID = 4, HuntID = 19},
                    new HuntersHunt {HunterID = 4, HuntID = 20},
                    new HuntersHunt {HunterID = 4, HuntID = 21},
                    new HuntersHunt {HunterID = 4, HuntID = 23},
                    new HuntersHunt {HunterID = 4, HuntID = 24},
                    new HuntersHunt {HunterID = 4, HuntID = 25},
                    new HuntersHunt {HunterID = 4, HuntID = 26},
                    new HuntersHunt {HunterID = 4, HuntID = 28},
                    new HuntersHunt {HunterID = 4, HuntID = 29},
                    new HuntersHunt {HunterID = 4, HuntID = 30},

                    new HuntersHunt {HunterID = 5, HuntID = 2},
                    new HuntersHunt {HunterID = 5, HuntID = 3},
                    new HuntersHunt {HunterID = 5, HuntID = 4},
                    new HuntersHunt {HunterID = 5, HuntID = 5},
                    new HuntersHunt {HunterID = 5, HuntID = 7},
                    new HuntersHunt {HunterID = 5, HuntID = 8},
                    new HuntersHunt {HunterID = 5, HuntID = 9},
                    new HuntersHunt {HunterID = 5, HuntID = 10},
                    new HuntersHunt {HunterID = 5, HuntID = 12},
                    new HuntersHunt {HunterID = 5, HuntID = 13},
                    new HuntersHunt {HunterID = 5, HuntID = 14},
                    new HuntersHunt {HunterID = 5, HuntID = 15},
                    new HuntersHunt {HunterID = 5, HuntID = 17},
                    new HuntersHunt {HunterID = 5, HuntID = 18},
                    new HuntersHunt {HunterID = 5, HuntID = 19},
                    new HuntersHunt {HunterID = 5, HuntID = 20},
                    new HuntersHunt {HunterID = 5, HuntID = 22},
                    new HuntersHunt {HunterID = 5, HuntID = 23},
                    new HuntersHunt {HunterID = 5, HuntID = 24},
                    new HuntersHunt {HunterID = 5, HuntID = 25},
                    new HuntersHunt {HunterID = 5, HuntID = 27},
                    new HuntersHunt {HunterID = 5, HuntID = 28},
                    new HuntersHunt {HunterID = 5, HuntID = 29},
                    new HuntersHunt {HunterID = 5, HuntID = 30},
                    
                };
                context.AddRange(hdmg);

                context.SaveChanges();
            }
        }
    }
}