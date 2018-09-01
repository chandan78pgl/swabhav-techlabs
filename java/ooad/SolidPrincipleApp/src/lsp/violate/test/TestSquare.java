package lsp.violate.test;

import static org.junit.Assert.*;
import lsp.violate.Rectangle;
import lsp.violate.Square;

import org.junit.Test;

public class TestSquare {

	@Test
	public void Test(){
		Square square=new Square(70);
		boolean actual=shouldNotChangeWidthIfHeightChanges(square);
		assertEquals(true, actual);
		
	}
	
	public boolean shouldNotChangeWidthIfHeightChanges(Rectangle r) {
		int beforeChangeHeight=r.getWidth();
		
		r.setHeight(r.getHeight()+20);
		
		int afterChangeHeight=r.getWidth();
		
		return (beforeChangeHeight==afterChangeHeight);
	}

}