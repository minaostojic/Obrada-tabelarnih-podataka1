using System;

class MainClass {
  public static void Main (string[] args) {
      StreamReader podaci = new StreamReader("ulaz.txt");
    string[,] matrica = new string[1000,6];
    int brojac=0;
    string s = podaci.ReadLine();
    if (File.Exists("ulaz.txt"))
    {
      while (!podaci.EndOfStream)
      {
        s = podaci.ReadLine();
        string[] elementi = s.Split(";"); //provera
        for (int i=0; i<6; i++)
        {
          matrica[brojac,i] = elementi[i];
        }
        brojac++;
      }
    }
    NajmanjePopularanZanr(matrica);
    /*for (int i=0;i<1000;i++)
    {
      for (int j=0;j<6;j++)
      {
        Console.Write(matrica[i,j]+" ");
      }
      Console.WriteLine();
    }*/
  }
}