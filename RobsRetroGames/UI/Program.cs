using UI;
using BL;
using DL;

IRepository repo = new FileRepository();
IRobsBL bl = new RRGBL(repo);
new MainMenu(bl).Start();