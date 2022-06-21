using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Play
    {
      
        public bool Turn { get; set; } = false;
        public bool changeTurn( ) => Turn == false ? true : false;
    } 
}

//클래스 안에 있으면 안된다. 클래스 자체는 청사진 같은 것. 설계도 안에 실행을 넣을 수 없다. 
//실제 실행시에 각각 클래스에 필요한 것을 가져다가 사용한다.