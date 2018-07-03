using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace TilingWithPentominos
{
    
    
    internal static class Program
    {
        
        
        public static void Main(string[] args)
        {
            var pentominos = SetupPentiminos();
        }

        private static IEnumerable<Pentomino> SetupPentiminos()
        {
            var pentominos = new Pentomino[24];
            pentominos[0].Name = 'F';
            pentominos[0].Coordinates = new int[,]
            {
                {1,0},
                {0,1},
                {1,1},
                {1,2},
                {2,2}
            };
            
            pentominos[1].Name = 'I';
            pentominos[1].Coordinates = new int[,]
            {
                {0,0},
                {0,1},
                {0,2},
                {0,3},
                {0,4}
            };
            
            pentominos[2].Name = 'L';
            pentominos[2].Coordinates = new int[,]
            {
                {0,0},
                {1,0},
                {0,1},
                {0,2},
                {0,3}
            };
            
            pentominos[3].Name = 'N';
            pentominos[3].Coordinates = new int[,]
            {
                {0,0},
                {0,1},
                {1,1},
                {1,2},
                {1,3}
            };
            
            pentominos[4].Name = 'P';
            pentominos[4].Coordinates = new int[,]
            {
                {0,0},
                {0,1},
                {1,1},
                {2,1},
                {2,2}
            };
            
            pentominos[5].Name = 'T';
                          pentominos[5].Coordinates = new int[,]
                          {
                              {0,1},
                              {1,1},
                              {0,2},
                              {1,2},
                              {2,2}
                          };

            pentominos[6].Name = 'U';
            pentominos[6].Coordinates = new int[,]
            {
                {0,0},
                {0,1},
                {0,2},
                {1,0},
                {1,2}
            };
            
            pentominos[7].Name = 'V';
            pentominos[7].Coordinates = new int[,]
            {
                {0,0},
                {0,1},
                {0,2},
                {1,2},
                {2,2}
            };
            
            pentominos[8].Name = 'W';
            pentominos[8].Coordinates = new int[,]
            {
                {0,0},
                {0,1},
                {1,1},
                {1,2},
                {2,2}
            };
            
            pentominos[9].Name = 'X';
            pentominos[9].Coordinates = new int[,]
            {
                {0,1},
                {1,0},
                {1,1},
                {1,2},
                {2,1}
            };
            
            pentominos[10].Name = 'Y';
            pentominos[10].Coordinates = new int[,]
            {
                {0,1},
                {1,1},
                {2,0},
                {2,1},
                {3,1}
            };
            
            pentominos[11].Name = 'Z';
            pentominos[11].Coordinates = new int[,]
            {
                {0,1},
                {0,2},
                {1,1},
                {2,0},
                {2,1}
            };
            
            return pentominos;
        }
    }
}