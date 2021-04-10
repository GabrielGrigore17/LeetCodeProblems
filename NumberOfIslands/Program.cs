using System;
using System.Collections.Generic;

namespace NumberOfIslands
{
    class Program
    {
        public int NumIslands(char[][] grid) {
            int numberOfIslands = 0;
            for(int i = 0; i < grid.Length; i++){
                for(int j = 0; j < grid[i].Length; j++){
                    if(grid[i][j] == '0')
                        continue;
                    numberOfIslands++;
                    checkNeibours(i, j);
                }

            }
            return numberOfIslands;

            void checkNeibours(int i, int j){
                if(i + 1 < grid.Length){
                    if(grid[i + 1][j] == '1'){
                        grid[i+1][j] = '0';
                        checkNeibours(i+1, j);
                    }                    
                }
                if(i - 1 >= 0){
                    if(grid[i - 1][j] == '1'){
                        grid[i-1][j] = '0';
                        checkNeibours(i-1, j);
                    }
                }
                if(j + 1 < grid[i].Length){
                    if(grid[i][j + 1] == '1'){
                        grid[i][j+1] = '0';
                        checkNeibours(i, j+1);
                    }
                }
                if(j - 1 >= 0){
                    if(grid[i][j - 1] == '1'){
                        grid[i][j-1] = '0';
                        checkNeibours(i, j-1);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
