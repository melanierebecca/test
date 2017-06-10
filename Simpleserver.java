import java.net.*;
import java.io.*;
public class Simpleserver
{
	public static void main(string arg[]) throws IOException
	{
		ServerSocket s=new ServerSocket(1254);
		Socket s1=s.accept();
		OutputStream s1out=new OutputStream();
		DataOutputStream dos=new DataOutputStream();
		dos.writeOTF("Hi there,,");
		dos.close();
		slout.close();
		s1.close();
	}
}