using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomicNomad.data.rooms
{
    internal class GameMapReference
    {
    }
}
/*



                        | office bathroom | 32
                                 ^                             
                                 |
                        | employee room | 31
                                 ^                             
      30                        29                             28
    |freezer | <--------> | Gas station |   <------->   | parking lot |
                                                               ^
                                                               |                             26                                                                                                          18
                                                   27  | bldg2 pergola | <-------> | bldg2 courtyard |                                  | bldg2 classroom4 | 22                                  | bldg2 classroom2 |                                 | bldg2 office | 14
                                                                                             ^                                                    ^                                                       ^                                                   ^
                                                                                            24                     23                            20                         19                            16                         15                       |
                                                                                      | bldg2 Exit | <----->| bldg2 Hallway 6 | <-------->| bldg2 Hallway 5 | <----->| bldg2 Hallway 4 | <-----> | bldg2 Hallway 3 | <----->| bldg2 Hallway 2 | ----- | bldg2 hallway 1 | 13
                                                                                             ^                                                    ^                                                       ^                                                   ^
                                                                                             |                                                    |                                                       |                                                   |
                                                                                   25   | bathroom |                                    | bldg2 classroom3 | 21                                  | bldg2 classroom1 | 17                            | bldg2 enterance | 12
                                                                                                                                                                                                                                                              ^
                                                                                                                                                                                                                                                              |
                                                                                                                                                                                                                                                       | plavilion | 11
                                                                                                                                                                                                                                                              ^
                                                                                                                                                                                                          7                                                   |
                                                                                                                                                                                                 | bldg1 classroom2 |                                   | breezway | 10
                                                                                                                                                                                                         ^                                                    ^
                                                                                                START                                                                                                    |                                                    |
                                                                                              barracks | <--------> | bldg1 hallway1 | <--------> | cafeteria | <-------> | courtyard | <-------> |bldg1 hallway2 | ------- |bldg1 hallway3 | -------- | bldg1 exit |
                                                                                                    1                          2                          3                     4                        5                           8                        9
                                                                                                                                                                                                         _
                                                                                                                                                                                                    bldg1 classroom1
                                                                                                                                                                                                         6


{ "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " };
{ "  ", "  ", "32", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " };
{ "  ", "  ", "31", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " };
{ "  ", "30", "29", "28", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " };
{ "  ", "  ", "  ", "27", "26", "  ", "22", "  ", "18", "  ", "14", "  " };
{ "  ", "  ", "  ", "  ", "24", "23", "20", "19", "16", "15", "13", "  " };
{ "  ", "  ", "  ", "  ", "25", "  ", "21", "  ", "17", "  ", "12", "  " };
{ "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "11", "  " };
{ "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "06", "  ", "10", "  " };
{ "  ", "  ", "  ", "  ", "01", "02", "03", "04", "05", "08", "09", "  " };
{ "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "07", "  ", "  ", "  " };
{ "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  ", "  " };



*/