 using UnityEngine;
    using UnityEngine.AI;
    
    public class PlayerController : MonoBehaviour {
       
       public Transform goal;
       string str1,str2;
       void Start () {
         switch(DropDownHandler1.sendercopy1)
         {
            string str;
int num = 0;

switch (num)
{    case 0:
        str1 = "A-101 Visitors Room";
        break;
    case 1:
        str1 = "A-102 Staff Room";
        break;
    case 2:
        str1 = "A-103 Staff Room";
        break;
    case 3:
        str1 = "A-104 Basic Electronics Lab";
        break;
    case 4:
        str1 = "A-105 Language Lab";
        break;
    case 5:
        str1 = "A-106 ME-2 Lecture Hall";
        break;
    case 6:
        str1 = "A-107 ME-1 Lecture Hall";
        break;
    case 7:
        str1 = "A-108 EC-2 Lecture Hall";
        break;
    case 8:
        str1 = "A-109 EC-1 Lecture Hall";
        break;
    case 9:
        str1 = "A-10BW Boys' Washroom";
        break;
    case 10:
        str1 = "A-10GW Girls' Washroom";
        break;
    case 11:
        str1 = "A-201 Conference Hall";
        break;
    case 12:
        str1 = "A-203 Principal";
        break;
    case 13:
        str1 = "A-205 Office";
        break;
    case 14:
        str1 = "A-206 Dining Hall";
        break;
    case 15:
        str1 = "A-207 Exam Cell";
        break;
    case 16:
        str1 = "A-208 Staff Room";
        break;
    case 17:
        str1 = "A-209 Toilet";
        break;
    case 18:
        str1 = "A-20BO Bursar's Office";
        break;
    case 19:
        str1 = "A-20BR Board Room";
        break;
    case 20:
        str1 = "A-20S Senatus Hall";
        break;
    case 21:
        str1 = "A-20W Washroom";
        break;
    case 22:
        str1 = "A-301 Staff Room";
        break;
    case 23:
        str1 = "A-302 HOD";
        break;
    case 24:
        str1 = "A-303 Chemistr1y Lab/Physics Lab";
        break;
    case 25:
        str1 = "A-304 CE-2 Lecture Hall";
        break;
    case 26:
        str1 = "A-304(A) EE-1 Lecture Hall";
        break;
    case 27:
        str1 = "A-305 CS-1 Lecture Hall";
        break;
    case 28:
        str1 = "A-306 CS-2 Lecture Hall";
        break;
    case 29:
        str1 = "A-307 CE-1 Lecture Hall";
        break;
    case 30:
        str1 = "A-308 EE-2 Lecture Hall";
        break;
    case 31:
        str1 = "A-30BW Boys' Washroom";
        break;
    case 32:
        str1 = "A-30GW Girls' Washroom";
        break;
    case 33:
        str1 = "A-30VP Vice Principal's Office";
        break;
    case 34:
        str1 = "B-01 HOD";
        break;
    case 35:
        str1 = "B-02 Lecture Hall";
        break;
    case 36: str1="";break;
        str1 = "B-03 Lecture Hall";
        break;
case 37: str1="B-104 Shannon Hall";break;
case 38: str1="B-104(a)";break;
case 39: str1="B-105(a) IC Lab";break;
case 40: str1="B-105(b) Advanced Communication Lab";break;
case 41: str1="B-109 Lecture Hall";break; 
case 42: str1="B-10BW Boys' Washroom";break;
case 43: str1="B-10SW Staff Washroom";break;
case 44: str1="B-11 EC & M1 Lab ";break;
case 45: str1="B-111 Staff Room ";break;
case 46: str1="B-113 Lecture Hall ";break;
case 47: str1="B-117 Digital Electronics Lab";break; 
case 48: str1="B-119 Library  ";break;
case 49: str1="B-119(a) Staff Room ";break;
case 50: str1="B-13 Staff Room";break; 
case 51: str1="B-200 HoD CS ";break;
case 52: str1="B-200(a) Dean RD";break; 
case 53: str1="B-202 Lecture Hall ";break;
case 54: str1="B-203 Lecture Hall ";break;
case 55: str1="B-204 AI Lab";break; 
case 56: str1="B-205 Lecture Hall ";break;
case 57: str1="B-205(a) Staffroom ";break;
case 58: str1="B-209 Project Lab -2";break; 
case 59: str1="B-20BW Boys' Washroom";break;
case 60: str1="B-20GW Girls' Washroom";break;
case 61: str1="B-20MC Maintainance Cell";break;
case 62: str1="B-20TP TPO";break;
case 63: str1="B-211 Staff Room ";break;
case 64: str1="B-213 Lecture Hall ";break;
case 65: str1="B-217 Communication Engineering Lab ";break;
case 66: str1="B-219 Staff Room ";break;
case 67: str1="B-300 Professor ";break;
case 68: str1="B-300(a) Staff Room (CS) ";break;
case 69: str1="B-301 Dean (PG) ";break;
case 70: str1="B-302 Lecture Hall ";break;
case 71: str1="B-303 Aryabhata Hall ";break;
case 72: str1="B-304(a) Pascal Hall ";break;
case 73: str1="B-304(b) Discussion Room ";break;
case 74: str1="B-30BW Boys' Washroom";break;
case 75: str1="B-30GW Girls' Washroom";break;
case 76: str1="B-30PG PG Lecture Hall ";break;
case 77: str1="B-213 Lecture Hall ";break;
case 78: str1="B-20MC Maintainance Cell";break;
case 79: str1="Reception";break;
case 80: str1="Stage";break;

         }
         switch(DropDownHandler2.sendercopy2)
         {
            
    case 0:
        str2 = "A-101 Visitors Room";
        break;
    case 1:
        str2 = "A-102 Staff Room";
        break;
    case 2:
        str2 = "A-103 Staff Room";
        break;
    case 3:
        str2 = "A-104 Basic Electronics Lab";
        break;
    case 4:
        str2 = "A-105 Language Lab";
        break;
    case 5:
        str2 = "A-106 ME-2 Lecture Hall";
        break;
    case 6:
        str2 = "A-107 ME-1 Lecture Hall";
        break;
    case 7:
        str2 = "A-108 EC-2 Lecture Hall";
        break;
    case 8:
        str2 = "A-109 EC-1 Lecture Hall";
        break;
    case 9:
        str2 = "A-10BW Boys' Washroom";
        break;
    case 10:
        str2 = "A-10GW Girls' Washroom";
        break;
    case 11:
        str2 = "A-201 Conference Hall";
        break;
    case 12:
        str2 = "A-203 Principal";
        break;
    case 13:
        str2 = "A-205 Office";
        break;
    case 14:
        str2 = "A-206 Dining Hall";
        break;
    case 15:
        str2 = "A-207 Exam Cell";
        break;
    case 16:
        str2 = "A-208 Staff Room";
        break;
    case 17:
        str2 = "A-209 Toilet";
        break;
    case 18:
        str2 = "A-20BO Bursar's Office";
        break;
    case 19:
        str2 = "A-20BR Board Room";
        break;
    case 20:
        str2 = "A-20S Senatus Hall";
        break;
    case 21:
        str2 = "A-20W Washroom";
        break;
    case 22:
        str2 = "A-301 Staff Room";
        break;
    case 23:
        str2 = "A-302 HOD";
        break;
    case 24:
        str2 = "A-303 Chemistr2y Lab/Physics Lab";
        break;
    case 25:
        str2 = "A-304 CE-2 Lecture Hall";
        break;
    case 26:
        str2 = "A-304(A) EE-1 Lecture Hall";
        break;
    case 27:
        str2 = "A-305 CS-1 Lecture Hall";
        break;
    case 28:
        str2 = "A-306 CS-2 Lecture Hall";
        break;
    case 29:
        str2 = "A-307 CE-1 Lecture Hall";
        break;
    case 30:
        str2 = "A-308 EE-2 Lecture Hall";
        break;
    case 31:
        str2 = "A-30BW Boys' Washroom";
        break;
    case 32:
        str2 = "A-30GW Girls' Washroom";
        break;
    case 33:
        str2 = "A-30VP Vice Principal's Office";
        break;
    case 34:
        str2 = "B-01 HOD";
        break;
    case 35:
        str2 = "B-02 Lecture Hall";
        break;
    case 36: str2="";break;
        str2 = "B-03 Lecture Hall";
        break;
case 37: str2="B-104 Shannon Hall";break;
case 38: str2="B-104(a)";break;
case 39: str2="B-105(a) IC Lab";break;
case 40: str2="B-105(b) Advanced Communication Lab";break;
case 41: str2="B-109 Lecture Hall";break; 
case 42: str2="B-10BW Boys' Washroom";break;
case 43: str2="B-10SW Staff Washroom";break;
case 44: str2="B-11 EC & M1 Lab ";break;
case 45: str2="B-111 Staff Room ";break;
case 46: str2="B-113 Lecture Hall ";break;
case 47: str2="B-117 Digital Electronics Lab";break; 
case 48: str2="B-119 Library  ";break;
case 49: str2="B-119(a) Staff Room ";break;
case 50: str2="B-13 Staff Room";break; 
case 51: str2="B-200 HoD CS ";break;
case 52: str2="B-200(a) Dean RD";break; 
case 53: str2="B-202 Lecture Hall ";break;
case 54: str2="B-203 Lecture Hall ";break;
case 55: str2="B-204 AI Lab";break; 
case 56: str2="B-205 Lecture Hall ";break;
case 57: str2="B-205(a) Staffroom ";break;
case 58: str2="B-209 Project Lab -2";break; 
case 59: str2="B-20BW Boys' Washroom";break;
case 60: str2="B-20GW Girls' Washroom";break;
case 61: str2="B-20MC Maintainance Cell";break;
case 62: str2="B-20TP TPO";break;
case 63: str2="B-211 Staff Room ";break;
case 64: str2="B-213 Lecture Hall ";break;
case 65: str2="B-217 Communication Engineering Lab ";break;
case 66: str2="B-219 Staff Room ";break;
case 67: str2="B-300 Professor ";break;
case 68: str2="B-300(a) Staff Room (CS) ";break;
case 69: str2="B-301 Dean (PG) ";break;
case 70: str2="B-302 Lecture Hall ";break;
case 71: str2="B-303 Aryabhata Hall ";break;
case 72: str2="B-304(a) Pascal Hall ";break;
case 73: str2="B-304(b) Discussion Room ";break;
case 74: str2="B-30BW Boys' Washroom";break;
case 75: str2="B-30GW Girls' Washroom";break;
case 76: str2="B-30PG PG Lecture Hall ";break;
case 77: str2="B-213 Lecture Hall ";break;
case 78: str2="B-20MC Maintainance Cell";break;
case 79: str2="Reception";break;
case 80: str2="Stage";break;

         }
          NavMeshAgent agent = GetComponent<NavMeshAgent>();
          GameObject.Find("Initial location").transform.position=GameObject.Find(str1).transform.position;
          goal.transform.position =GameObject.Find(str2).transform.position; 
          agent.destination=goal.position;
       }
    }