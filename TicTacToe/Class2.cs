using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Play
    {
        private const string empty = " ";

        public bool Turn { get; set; } = false;
        public bool changeTurn( ) => Turn == false ? true : false;
        public List<string> Land { get; set; }  
        
        public void DrawBoard(List<string> field)
        {
            Console.WriteLine("       |       |     ");
            Console.WriteLine($"   {field[0]}   |   {field[1]}   |   {field[2]} ");
            Console.WriteLine("       |       |    ");
            Console.WriteLine("------------------------");
            Console.WriteLine("       |       |     ");
            Console.WriteLine($"   {field[3]}   |   {field[4]}   |   {field[5]} ");
            Console.WriteLine("       |       |    ");
            Console.WriteLine("------------------------");
            Console.WriteLine("       |       |     ");
            Console.WriteLine($"   {field[6]}   |   {field[7]}   |   {field[8]} ");
            Console.WriteLine("       |       |    ");
        }
    } 
}

//클래스 안에 있으면 안된다. 클래스 자체는 청사진 같은 것. 설계도 안에 실행을 넣을 수 없다. 
//실제 실행시에 각각 클래스에 필요한 것을 가져다가 사용한다.