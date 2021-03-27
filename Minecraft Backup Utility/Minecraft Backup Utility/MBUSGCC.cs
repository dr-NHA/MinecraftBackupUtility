using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace Minecraft_Backup_Utility{
 public partial class MBUSGCC : Form{
public static bool SuperGalacticButtonMode=false;
public MBUSGCC(){
InitializeComponent();
this.Region= MakeCircular(this.Width, this.Height, 110, 110);
int[] ButtonElips = { 121,121};
if(SuperGalacticButtonMode==true){
MinimizeMBU.Region= MakeCircular(MinimizeMBU,ButtonElips[0],ButtonElips[1]);
CloseMBU.Region= MakeCircular(CloseMBU, ButtonElips[0],ButtonElips[1]);
ReloadBackups.Region= MakeCircular(ReloadBackups, ButtonElips[0],ButtonElips[1]);
ReloadGameSaves.Region= MakeCircular(ReloadGameSaves, ButtonElips[0],ButtonElips[1]);
InjectSelectedBackup.Region= MakeCircular(InjectSelectedBackup, ButtonElips[0],ButtonElips[1]);
DoBackupFromSelected.Region= MakeCircular(DoBackupFromSelected, ButtonElips[0],ButtonElips[1]);
CopyAllBackToGame.Region= MakeCircular(CopyAllBackToGame, ButtonElips[0],ButtonElips[1]);
BackupAll.Region= MakeCircular(BackupAll, ButtonElips[0],ButtonElips[1]);
DeleteBackup.Region= MakeCircular(DeleteBackup, ButtonElips[0],ButtonElips[1]);
DeleteSave.Region= MakeCircular(DeleteSave, ButtonElips[0],ButtonElips[1]);
}
}

public static Region MakeCircular(Label inax,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, inax.Width, inax.Height, 50, 50)); }
public static Region MakeCircular(PictureBox inax,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, inax.Width, inax.Height, 50, 50)); }
public static Region MakeCircular(Panel inax,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, inax.Width, inax.Height, 50, 50)); }
public static Region MakeCircular(Button inax,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, inax.Width, inax.Height, 50, 50)); }
public static Region MakeCircular(TextBox inax,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, inax.Width, inax.Height, 50, 50)); }
public static Region MakeCircular(ListBox inax,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, inax.Width, inax.Height, 50, 50)); }
public static Region MakeCircular(int width,int height,int Welip,int Helip) {return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, width, height, 50, 50)); }

[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
public  static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
[DllImportAttribute("user32.dll")]
public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
[DllImportAttribute("user32.dll")]
public static extern bool ReleaseCapture();


private void MBUSGCC_Load(object sender, EventArgs e){
ReloadBackupSaveGames();
ReloadReelSaveGames(); 
}

private void CloseMBU_Click(object sender, EventArgs e){
AppCloseProcess();

}

async Task AppCloseProcess(){
async Task Exitr() { await Task.Delay(100);Environment.FailFast(""); }
Exitr();
this.Close();
this.Dispose();

}

private void MoveAbleWindow_MouseMove(object sender, MouseEventArgs e){
 if (e.Button == MouseButtons.Left){
ReleaseCapture();
SendMessage(Handle, 0xA1, 0x2, 0);
 }
}

private void MinimizeMBU_Click(object sender, EventArgs e){
MinimizeMBUNow(this);
}

async Task MinimizeMBUNow(object mbu){
((Form)mbu).WindowState = FormWindowState.Minimized;
}

private void ReloadBackups_Click(object sender, EventArgs e){
ReloadBackupSaveGames();
}

private void ReloadGameSaves_Click(object sender, EventArgs e)
{
ReloadReelSaveGames();
}

private void InjectSelectedBackup_Click(object sender, EventArgs e){
if (BackupList.SelectedIndex>-1) {
 PullBackup(BackupList.SelectedIndex);
AutoReloadBasedOffProcesses("sg");
}
}

private void DoBackupFromSelected_Click(object sender, EventArgs e){
if (SaveGameList.SelectedIndex > -1) {
 DoBackup(SaveGameList.SelectedIndex);
AutoReloadBasedOffProcesses("bk");
}
}



private void DeleteBackup_Click(object sender, EventArgs e){
if (BackupList.SelectedIndex > -1){
 Directory.Delete(BackupGamesavepaths[BackupList.SelectedIndex], true);
 ReloadBackupSaveGames();
}
}


private void DeleteSave_Click(object sender, EventArgs e){
if (SaveGameList.SelectedIndex > -1){
 Directory.Delete(ReelGamesavepaths[SaveGameList.SelectedIndex], true);
 ReloadReelSaveGames();
}
}


private void BackupAll_Click(object sender, EventArgs e){
for(var i=0;i< ReelGamesavepaths.Count;i++){
 DoBackup(i);
}
AutoReloadBasedOffProcesses("bk");
}
        
private void CopyAllBackToGame_Click(object sender, EventArgs e){
for(var i=0;i<BackupGamesavepaths.Count;i++){
PullBackup(i);
}
AutoReloadBasedOffProcesses("sg");
}


async Task DoBackup(int savegame){
string savelocation = ReelGamesavepaths[savegame];
string newlocation = MakeNewFolderIfOnePresentAt( dirforbackups + "\\" + fnfd(savelocation));
CreateBackupOrPull("bk",savelocation, newlocation);
}
 async Task PullBackup(int savegame){
string savelocation = BackupGamesavepaths[savegame];
string newlocation = MakeNewFolderIfOnePresentAt( minecraftdirsavegames + "\\" + fnfd(savelocation));
CreateBackupOrPull("sg",savelocation, newlocation);
}
        
List<Process> GamesaveProx = new List<Process>();
List<Process> BackupProx=new List<Process>();
async Task AutoReloadBasedOffProcesses(string tpr){
await Task.Delay(100);
if(tpr=="bk"){
await DoReloadOfThisWhenNeeded(BackupProx, "bk");
}else{
await DoReloadOfThisWhenNeeded(GamesaveProx, "bk");
}
}

async Task DoReloadOfThisWhenNeeded(List<Process> proxs,string tpr){
for(;;){
bool stopped=true;
foreach(Process prox in proxs){
if(prox.HasExited==false){ stopped = false;}}
if(stopped==true) { ReloadOfTpr(tpr); break; }
await Task.Delay(100);
}
}

void ReloadOfTpr(string tpr){
if(tpr=="bk"){
ReloadBackupSaveGames();
}else{
ReloadReelSaveGames();
}
}


async Task CreateBackupOrPull(string tpr,string savelocation,string newlocation){
Directory.CreateDirectory(newlocation);
string sc = '"'.ToString();
Process Copyviawintask =new Process();
Copyviawintask.StartInfo.Arguments="/E /I "+sc+savelocation+sc+" "+sc+newlocation+sc;
Copyviawintask.StartInfo.WorkingDirectory=Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
Copyviawintask.StartInfo.CreateNoWindow=true;
Copyviawintask.StartInfo.WindowStyle=ProcessWindowStyle.Hidden;
Copyviawintask.StartInfo.FileName= "XCOPY.exe";
if(tpr=="bk"){
BackupProx.Add(Copyviawintask);
}else{
GamesaveProx.Add(Copyviawintask);

}
Copyviawintask.Start();
}


string MakeNewFolderIfOnePresentAt(string newlocation){
string tryloc = newlocation;
var i = 2;
for(;;){
if (!Directory.Exists(tryloc)) {
return tryloc;
break;
}
 tryloc = newlocation + " ("+i+")";i++;
}
}

string fnfd(string dir){
if (dir.Contains('\\')) {
 return dir.Split('\\')[dir.Split('\\').Length - 1];
}else{
 return dir;
}
}




string dirforbackups = Environment.CurrentDirectory + "\\" + "MBU BKS";
List<string> BackupGamesaves = new List<string>();
List<string> BackupGamesavepaths = new List<string>();
async Task ReloadBackupSaveGames() {
if (!Directory.Exists(dirforbackups)){Directory.CreateDirectory(dirforbackups);}
 BackupGamesaves.Clear(); BackupGamesavepaths.Clear();
 BackupList.Items.Clear();
 List<string> TmpGamesaves = new List<string>(Directory.GetDirectories(dirforbackups));
foreach (string backupgamesavepath in TmpGamesaves){
BackupGamesavepaths.Add(backupgamesavepath);
 if ( File.Exists(backupgamesavepath + "\\levelname.txt")){
BackupGamesaves.Add(File.ReadAllText(backupgamesavepath + "\\levelname.txt"));
}else{
BackupGamesaves.Add(backupgamesavepath.Split('\\')[backupgamesavepath.Split('\\').Length-1]);
 }
 }

 BackupList.Items.AddRange(BackupGamesaves.ToArray());
}


public static string minecraftdir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState";
public static string minecraftdirsavegametemplates = minecraftdir + @"\premium_cache\world_templates";
public static string minecraftdirresourcepacks = minecraftdir + @"\games\com.mojang\resource_packs";
public static string minecraftdirskinpacks = minecraftdir + @"\games\com.mojang\skin_packs";

public static string minecraftdirsavegames = minecraftdir+ @"\games\com.mojang\minecraftWorlds";

List<string> ReelGamesaves = new List<string>();
List<string> ReelGamesavepaths = new List<string>();
async Task ReloadReelSaveGames() {
if (!Directory.Exists(minecraftdirsavegames)){
 Directory.CreateDirectory(minecraftdirsavegames);
}
 ReelGamesaves.Clear();ReelGamesavepaths.Clear();
 List<string> TmpGamesaves = new List<string>(Directory.GetDirectories(minecraftdirsavegames));
 foreach (string reelgamesavepath in TmpGamesaves){
ReelGamesavepaths.Add(reelgamesavepath);
 if( File.Exists(reelgamesavepath+"\\levelname.txt")){
ReelGamesaves.Add(File.ReadAllText(reelgamesavepath + "\\levelname.txt"));
}else{
ReelGamesaves.Add(reelgamesavepath.Split('\\')[reelgamesavepath.Split('\\').Length-1]);
 }
 }
 SaveGameList.Items.Clear();
 SaveGameList.Items.AddRange(ReelGamesaves.ToArray());
}

private void InfoBox_MouseDown(object sender, MouseEventArgs e){ this.ActiveControl = ((TextBox)sender).Parent; return;}

private void InfoBox_MouseUp(object sender, MouseEventArgs e){ this.ActiveControl = ((TextBox)sender).Parent;return; }

private void YoutubeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
Process.Start("https://youtube.com/c/drNHAGaming");
YoutubeLink.LinkVisited = true;
}

private void DiscordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
Process.Start("https://discord.gg/EFadqKJSr2");
DiscordLink.LinkVisited = true;
}

private void CabconLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
Process.Start("https://cabconmodding.com/members/dr-nha-mods.44193/");
CabconLink.LinkVisited=true;
}

private void Se7ensinsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
Process.Start("https://www.se7ensins.com/members/nohacksallowed.1062296/");
Se7sinsLink.LinkVisited=true;
}

private void UpdateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
Process.Start("https://github.com/dr-NHA/MinecraftBackupUtility");
UpdateLink.LinkVisited=true;
}

}
}
