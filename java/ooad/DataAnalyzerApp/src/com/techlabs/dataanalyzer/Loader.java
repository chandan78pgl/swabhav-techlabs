package com.techlabs.dataanalyzer;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.List;

public interface Loader {
	public List<String> loadData() throws FileNotFoundException, IOException;
}
