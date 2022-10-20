void menu(){
    Console.WriteLine("Which function does one desire to run? 1, 2, 3, or 4.?");
    string userInput = Console.ReadLine();
    switch (userInput){
        case "1":
        StackNoParams();
        Console.WriteLine("Function StackNoParams successful.");
        break;
        case "2":
        StackWithParams(4, 5, 6);
        Console.WriteLine("Function StackWithParams successful.");
        break;
        case "3":
        StackWithHeap(95, 33, 444, "something");
        Console.WriteLine("Function StackWithHeap successful.");
        break;
        case "4":
        StackOver(5000);
        break;
    }
}
menu();
void StackNoParams(){
    int a = 1;
    int b = 2;
    int c = 3;
    int d = 4;
    int e = 5;
}
void StackWithParams(int z, int x, int y){
}
void StackWithHeap(int e, int f, int g, string random){
    int j = 16;
    int k = 17;
    string l = "yeah";
}
void StackOver(long v){
    StackOver(1072874932);
}