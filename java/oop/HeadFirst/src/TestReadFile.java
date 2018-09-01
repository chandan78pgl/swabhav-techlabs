import java.io.BufferedReader;
import java.io.Closeable;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;


public class TestReadFile {
	public static void main(String[] args) throws FileNotFoundException,IOException{
		File file=new File("C:\\Users\\mahar\\Desktop\\Training\\newfile.txt");
		
		FileReader fr=new FileReader(file);
		BufferedReader br=new BufferedReader(fr);
		String line="";
		
		while((line=br.readLine())!=null){
			System.out.println(line);
		}
		br.close();
		fr.close();	
	}
}
