using System;
namespace a{
  class m{
  public static void Main()
{
string inp=Console.ReadLine();
bool[] a=new bool[5];
bool[] k=new bool[5];
bool[] s=new bool[5];
bool[] t=new bool[5];
bool[] n_=new bool[5];
bool[] h=new bool[5];
bool[] m=new bool[5];
bool[] y=new bool[4];
bool[] r=new bool[5];
bool[] w=new bool[5];
bool[] n=new bool[1];

bool[] g=new bool[5];
bool[] z=new bool[5];
bool[] d=new bool[5];
bool[] b=new bool[5];
bool[] p=new bool[5];

bool[] xy=new bool[3];

bool[] ky = new bool[4];//
bool[] sy = new bool[4];
bool[] ty = new bool[4];
bool[] ny = new bool[4];
bool[] hy = new bool[4];
bool[] my = new bool[4];
bool[] ry = new bool[4];

bool[] gy = new bool[4];
bool[] zy = new bool[4];
bool[] by = new bool[4];
bool[] py = new bool[4];

bool[] wi = new bool[3];
bool[] kwa = new bool[4];
bool[] swi = new bool[2];
bool[] tswa = new bool[4];
bool[] fa = new bool[4];
bool[] gwa = new bool[4];
bool[] twi = new bool[4];

bool breath=false;

for (int i =0;i<inp.Length;i++){
  if (inp[i]=='あ'&&(i+1>=inp.Length||(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ'))))) a[0]=true;
  if (inp[i]=='い'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) a[1]=true;
  if (inp[i]=='う'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) a[2]=true;
  if (inp[i]=='え'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) a[3]=true;
  if (inp[i]=='お'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) a[4]=true;
  
  if (inp[i]=='か'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) k[0]=true;
  if (inp[i]=='き'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) k[1]=true;
  if (inp[i]=='く'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) k[2]=true;
  if (inp[i]=='け'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) k[3]=true;
  if (inp[i]=='こ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) k[4]=true;
  
  if (inp[i]=='さ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) s[0]=true;
  if (inp[i]=='し'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) s[1]=true;
  if (inp[i]=='す'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) s[2]=true;
  if (inp[i]=='せ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) s[3]=true;
  if (inp[i]=='そ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) s[4]=true;
  
  if (inp[i]=='た'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) t[0]=true;
  if (inp[i]=='ち'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) t[1]=true;
  if (inp[i]=='つ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) t[2]=true;
  if (inp[i]=='て'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) t[3]=true;
  if (inp[i]=='と'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) t[4]=true;
  
  if (inp[i]=='な'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) n_[0]=true;
  if (inp[i]=='に'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) n_[1]=true;
  if (inp[i]=='ぬ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) n_[2]=true;
  if (inp[i]=='ね'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) n_[3]=true;
  if (inp[i]=='の'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) n_[4]=true;
  
  if (inp[i]=='は'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) h[0]=true;
  if (inp[i]=='ひ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) h[1]=true;
  if (inp[i]=='ふ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) h[2]=true;
  if (inp[i]=='へ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) h[3]=true;
  if (inp[i]=='ほ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) h[4]=true;
  
  if (inp[i]=='ま'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) m[0]=true;
  if (inp[i]=='み'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) m[1]=true;
  if (inp[i]=='む'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) m[2]=true;
  if (inp[i]=='め'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) m[3]=true;
  if (inp[i]=='も'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) m[4]=true;
  
  if (inp[i]=='や'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) y[0]=true;
  if (inp[i]=='ゆ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) y[1]=true;
  if (inp[i]=='い'&&i+1<inp.Length&&inp[i+1]!='ぇ') y[2]=true;
  if (inp[i]=='よ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) y[3]=true;
  
  if (inp[i]=='わ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) w[0]=true;
  if (inp[i]=='い'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) w[1]=true;
  if (inp[i]=='う'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) w[2]=true;
  if (inp[i]=='え'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) w[3]=true;
  if (inp[i]=='を'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) w[4]=true;
  
  if (inp[i]=='ら'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) r[0]=true;
  if (inp[i]=='り'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) r[1]=true;
  if (inp[i]=='る'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) r[2]=true;
  if (inp[i]=='れ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) r[3]=true;
  if (inp[i]=='ろ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) r[4]=true;

  if (inp[i]=='ん'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) n[0]=true;
  
  
  if (inp[i]=='が'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) g[0]=true;
  if (inp[i]=='ぎ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) g[1]=true;
  if (inp[i]=='ぐ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) g[2]=true;
  if (inp[i]=='げ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) g[3]=true;
  if (inp[i]=='ご'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) g[4]=true;
  
  if (inp[i]=='ざ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) z[0]=true;
  if (inp[i]=='じ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) z[1]=true;
  if (inp[i]=='ず'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) z[2]=true;
  if (inp[i]=='ぜ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) z[3]=true;
  if (inp[i]=='ぞ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) z[4]=true;
  
  if (inp[i]=='だ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) d[0]=true;
  if (inp[i]=='で'&&i+1<inp.Length&&inp[i+1]!='ぃ') d[1]=true;
  if (inp[i]=='づ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) d[2]=true;
  if (inp[i]=='で'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) d[3]=true;
  if (inp[i]=='ど'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) d[4]=true;
  
  if (inp[i]=='ば'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) b[0]=true;
  if (inp[i]=='び'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) b[1]=true;
  if (inp[i]=='ぶ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) b[2]=true;
  if (inp[i]=='べ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) b[3]=true;
  if (inp[i]=='ぼ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) b[4]=true;
  
  
  if (inp[i]=='ぱ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) p[0]=true;
  if (inp[i]=='ぴ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) p[1]=true;
  if (inp[i]=='ぷ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) p[2]=true;
  if (inp[i]=='ぺ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) p[3]=true;
  if (inp[i]=='ぽ'&&(i+1>=inp.Length||(i+1<inp.Length&&(inp[i+1]!='ょ'&&inp[i+1]!='ゅ'&&inp[i+1]!='ゃ')))) p[4]=true;
  
  if (inp[i]=='ゃ') xy[0]=true;
  if (inp[i]=='ゅ') xy[1]=true;
  if (inp[i]=='ょ') xy[2]=true;
  
  if (i+1<inp.Length&&inp[i]=='き'&&inp[i+1]=='ゃ') ky[0]=true;
  if (i+1<inp.Length&&inp[i]=='き'&&inp[i+1]=='ゅ') ky[1]=true;
  if (i+1<inp.Length&&inp[i]=='き'&&inp[i+1]=='ぇ') ky[2]=true;
  if (i+1<inp.Length&&inp[i]=='き'&&inp[i+1]=='ょ') ky[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='し'&&inp[i+1]=='ゃ') sy[0]=true;
  if (i+1<inp.Length&&inp[i]=='し'&&inp[i+1]=='ゅ') sy[1]=true;
  if (i+1<inp.Length&&inp[i]=='し'&&inp[i+1]=='ぇ') sy[2]=true;
  if (i+1<inp.Length&&inp[i]=='し'&&inp[i+1]=='ょ') sy[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='ち'&&inp[i+1]=='ゃ') ty[0]=true;
  if (i+1<inp.Length&&inp[i]=='ち'&&inp[i+1]=='ゅ') ty[1]=true;
  if (i+1<inp.Length&&inp[i]=='ち'&&inp[i+1]=='ぇ') ty[2]=true;
  if (i+1<inp.Length&&inp[i]=='ち'&&inp[i+1]=='ょ') ty[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='に'&&inp[i+1]=='ゃ') ny[0]=true;
  if (i+1<inp.Length&&inp[i]=='に'&&inp[i+1]=='ゅ') ny[1]=true;
  if (i+1<inp.Length&&inp[i]=='に'&&inp[i+1]=='ぇ') ny[2]=true;
  if (i+1<inp.Length&&inp[i]=='に'&&inp[i+1]=='ょ') ny[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='ひ'&&inp[i+1]=='ゃ') hy[0]=true;
  if (i+1<inp.Length&&inp[i]=='ひ'&&inp[i+1]=='ゅ') hy[1]=true;
  if (i+1<inp.Length&&inp[i]=='ひ'&&inp[i+1]=='ぇ') hy[2]=true;
  if (i+1<inp.Length&&inp[i]=='ひ'&&inp[i+1]=='ょ') hy[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='み'&&inp[i+1]=='ゃ') my[0]=true;
  if (i+1<inp.Length&&inp[i]=='み'&&inp[i+1]=='ゅ') my[1]=true;
  if (i+1<inp.Length&&inp[i]=='み'&&inp[i+1]=='ぇ') my[2]=true;
  if (i+1<inp.Length&&inp[i]=='み'&&inp[i+1]=='ょ') my[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='り'&&inp[i+1]=='ゃ') ry[0]=true;
  if (i+1<inp.Length&&inp[i]=='り'&&inp[i+1]=='ゅ') ry[1]=true;
  if (i+1<inp.Length&&inp[i]=='り'&&inp[i+1]=='ぇ') ry[2]=true;
  if (i+1<inp.Length&&inp[i]=='り'&&inp[i+1]=='ょ') ry[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='ぎ'&&inp[i+1]=='ゃ') gy[0]=true;
  if (i+1<inp.Length&&inp[i]=='ぎ'&&inp[i+1]=='ゅ') gy[1]=true;
  if (i+1<inp.Length&&inp[i]=='ぎ'&&inp[i+1]=='ぇ') gy[2]=true;
  if (i+1<inp.Length&&inp[i]=='ぎ'&&inp[i+1]=='ょ') gy[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='じ'&&inp[i+1]=='ゃ') zy[0]=true;
  if (i+1<inp.Length&&inp[i]=='じ'&&inp[i+1]=='ゅ') zy[1]=true;
  if (i+1<inp.Length&&inp[i]=='じ'&&inp[i+1]=='ぇ') zy[2]=true;
  if (i+1<inp.Length&&inp[i]=='じ'&&inp[i+1]=='ょ') zy[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='び'&&inp[i+1]=='ゃ') by[0]=true;
  if (i+1<inp.Length&&inp[i]=='び'&&inp[i+1]=='ゅ') by[1]=true;
  if (i+1<inp.Length&&inp[i]=='び'&&inp[i+1]=='ぇ') by[2]=true;
  if (i+1<inp.Length&&inp[i]=='び'&&inp[i+1]=='ょ') by[3]=true;
  
  
  if (i+1<inp.Length&&inp[i]=='ぴ'&&inp[i+1]=='ゃ') py[0]=true;
  if (i+1<inp.Length&&inp[i]=='ぴ'&&inp[i+1]=='ゅ') py[1]=true;
  if (i+1<inp.Length&&inp[i]=='ぴ'&&inp[i+1]=='ぇ') py[2]=true;
  if (i+1<inp.Length&&inp[i]=='ぴ'&&inp[i+1]=='ょ') py[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='う'&&inp[i+1]=='ぃ') wi[0]=true;
  if (i+1<inp.Length&&inp[i]=='う'&&inp[i+1]=='ぇ') wi[1]=true;
  if (i+1<inp.Length&&inp[i]=='う'&&inp[i+1]=='ぉ') wi[2]=true;
  
  if (i+1<inp.Length&&inp[i]=='く'&&inp[i+1]=='ぁ') kwa[0]=true;
  if (i+1<inp.Length&&inp[i]=='く'&&inp[i+1]=='ぃ') kwa[1]=true;
  if (i+1<inp.Length&&inp[i]=='く'&&inp[i+1]=='ぇ') kwa[2]=true;
  if (i+1<inp.Length&&inp[i]=='く'&&inp[i+1]=='ぉ') kwa[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='す'&&inp[i+1]=='ぃ') swi[0]=true;
  if (i+1<inp.Length&&inp[i]=='ず'&&inp[i+1]=='ぃ') swi[1]=true;
  
  if (i+1<inp.Length&&inp[i]=='つ'&&inp[i+1]=='ぁ') tswa[0]=true;
  if (i+1<inp.Length&&inp[i]=='つ'&&inp[i+1]=='ぃ') tswa[1]=true;
  if (i+1<inp.Length&&inp[i]=='つ'&&inp[i+1]=='ぇ') tswa[2]=true;
  if (i+1<inp.Length&&inp[i]=='つ'&&inp[i+1]=='ぉ') tswa[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='ふ'&&inp[i+1]=='ぁ') fa[0]=true;
  if (i+1<inp.Length&&inp[i]=='ふ'&&inp[i+1]=='ぃ') fa[1]=true;
  if (i+1<inp.Length&&inp[i]=='ふ'&&inp[i+1]=='ぇ') fa[2]=true;
  if (i+1<inp.Length&&inp[i]=='ふ'&&inp[i+1]=='ぉ') fa[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='ぐ'&&inp[i+1]=='ぁ') gwa[0]=true;
  if (i+1<inp.Length&&inp[i]=='ぐ'&&inp[i+1]=='ぃ') gwa[1]=true;
  if (i+1<inp.Length&&inp[i]=='ぐ'&&inp[i+1]=='ぇ') gwa[2]=true;
  if (i+1<inp.Length&&inp[i]=='ぐ'&&inp[i+1]=='ぉ') gwa[3]=true;
  
  if (i+1<inp.Length&&inp[i]=='て'&&inp[i+1]=='ぃ') twi[0]=true;
  if (i+1<inp.Length&&inp[i]=='と'&&inp[i+1]=='ぅ') twi[1]=true;
  if (i+1<inp.Length&&inp[i]=='て'&&inp[i+1]=='ゅ') twi[2]=true;
  if (i+1<inp.Length&&inp[i]=='で'&&inp[i+1]=='ゅ') twi[3]=true;
  
  if (inp[i]=='息') breath=true;
}
Console.WriteLine("あ："+a[0]+",い："+a[1]+",う："+a[2]+",え："+a[3]+",お："+a[4]);
  Console.WriteLine("か："+k[0]+",き："+k[1]+",く："+k[2]+",け："+k[3]+",こ："+k[4]);
  Console.WriteLine("さ："+s[0]+",し："+s[1]+",す："+s[2]+",せ："+s[3]+",そ："+s[4]);
  Console.WriteLine("た："+t[0]+",ち："+t[1]+",つ："+t[2]+",て："+t[3]+",と："+t[4]);
  Console.WriteLine("な："+n_[0]+",に："+n_[1]+",ぬ："+n_[2]+",ね："+n_[3]+",の："+n_[4]);
  Console.WriteLine("は："+h[0]+",ひ："+h[1]+",ふ："+h[2]+",へ："+h[3]+",ほ："+h[4]);
  Console.WriteLine("ま："+m[0]+",み："+m[1]+",む："+m[2]+",め："+m[3]+",も："+m[4]);
  Console.WriteLine("や："+y[0]+",ゆ："+y[1]+",いぇ："+y[2]+",よ："+y[3]);
  Console.WriteLine("ら："+r[0]+",り："+r[1]+",る："+r[2]+",れ："+r[3]+",ろ："+r[4]);
  Console.WriteLine("わ："+w[0]+",い："+w[1]+",う："+w[2]+",え："+w[3]+",を："+w[4]);
  Console.WriteLine("ん："+n[0]);
  
  Console.WriteLine("が："+g[0]+",ぎ："+g[1]+",ぐ："+g[2]+",げ："+g[3]+",ご："+g[4]);
  Console.WriteLine("ざ："+z[0]+",じ："+z[1]+",ず："+z[2]+",ぜ："+z[3]+",ぞ："+z[4]);
  Console.WriteLine("だ："+d[0]+",でぃ："+d[1]+",づ："+d[2]+",で："+d[3]+",ど："+d[4]);
  Console.WriteLine("ば："+b[0]+",び："+b[1]+",ぶ："+b[2]+",べ："+b[3]+",ぼ："+b[4]);
  Console.WriteLine("ぱ："+p[0]+",ぴ："+p[1]+",ぷ："+p[2]+",ぺ："+p[3]+",ぽ："+p[4]);
  
  Console.WriteLine("ゃ："+xy[0]+",ゅ："+xy[1]+",ょ："+xy[2]);
  
  Console.WriteLine("きゃ："+ky[0]+",きゅ："+ky[1]+",きぇ："+ky[2]+",きょ："+ky[3]);
  Console.WriteLine("しゃ："+sy[0]+",しゅ："+sy[1]+",しぇ："+sy[2]+",しょ："+sy[3]);
  Console.WriteLine("ちゃ："+ty[0]+",ちゅ："+ty[1]+",ちぇ："+ty[2]+",ちょ："+ty[3]);
  Console.WriteLine("にゃ："+ny[0]+",にゅ："+ny[1]+",にぇ："+ny[2]+",にょ："+ny[3]);
  Console.WriteLine("ひゃ："+hy[0]+",ひゅ："+hy[1]+",ひぇ："+hy[2]+",ひょ："+hy[3]);
  Console.WriteLine("みゃ："+my[0]+",みゅ："+my[1]+",みぇ："+my[2]+",みょ："+my[3]);
  Console.WriteLine("りゃ："+ry[0]+",りゅ："+ry[1]+",りぇ："+ry[2]+",りょ："+ry[3]);
  
  Console.WriteLine("ぎゃ："+gy[0]+",ぎゅ："+gy[1]+",ぎぇ："+gy[2]+",ぎょ："+gy[3]);
  Console.WriteLine("じゃ："+zy[0]+",じゅ："+zy[1]+",じぇ："+zy[2]+",じょ："+zy[3]);
  Console.WriteLine("びゃ："+by[0]+",びゅ："+by[1]+",びぇ："+by[2]+",びょ："+by[3]);
  Console.WriteLine("ぴゃ："+py[0]+",ぴゅ："+py[1]+",ぴぇ："+py[2]+",ぴょ："+py[3]);
  
  Console.WriteLine("うぃ："+wi[0]+",うぇ："+wi[1]+",うぉ："+wi[2]);
  Console.WriteLine("くぁ："+kwa[0]+",くぃ："+kwa[1]+",くぇ："+kwa[2]+",くぉ："+kwa[3]);
  Console.WriteLine("すぃ："+swi[0]+",ずぃ："+swi[1]);
  Console.WriteLine("つぁ："+tswa[0]+",つぃ："+tswa[1]+",つぇ："+tswa[2]+",つぉ："+tswa[3]);
  Console.WriteLine("ふぁ："+fa[0]+",ふぃ："+fa[1]+",ふぇ："+fa[2]+",ふぉ："+fa[3]);
  Console.WriteLine("ぐぁ："+gwa[0]+",ぐぃ："+gwa[1]+",ぐぇ："+gwa[2]+",ぐぉ："+gwa[3]);
  Console.WriteLine("てぃ："+twi[0]+",とぅ："+twi[1]+",てゅ："+twi[2]+",でゅ："+twi[3]);
  Console.WriteLine("息："+breath);
}
}
}
