using System;

class Program {
  public static void Main (string[] args) {
    string Text = Console.ReadLine();
    Console.WriteLine(Text);
    int ZnakIrony = 0;

    if (Text.Contains("fakt") == true) {
    ZnakIrony ++;

    
}
    if (Text.Contains("slay") == true) {
    ZnakIrony ++;
      
}
    if (Text.Contains("vůbec") == true) {
    ZnakIrony ++;

    
}
    
    Console.WriteLine("Tato věta obsahuje znaků ironie: " + ZnakIrony);
    

  }
}
