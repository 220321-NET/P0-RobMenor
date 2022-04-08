using UI;
using BL;
using DL;

IRepository repo = new DBRepository();
IRobsBL bl = new RRGBL(repo);
new MainMenu(bl).Start();