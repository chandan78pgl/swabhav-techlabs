import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;


public class TestWriteFile {
	public static void main(String[] args) throws IOException{
		File file=new File("C:\\Users\\mahar\\Desktop\\Training\\newfile.txt");

		FileWriter fw=new FileWriter(file,true);
		BufferedWriter bw=new BufferedWriter(fw);
		
		String line= "This has to be written in file";
		
		bw.newLine();
		bw.append(line);
		
		bw.close();
		fw.close();
	}
}
