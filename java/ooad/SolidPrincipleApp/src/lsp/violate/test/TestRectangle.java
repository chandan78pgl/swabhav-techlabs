package lsp.violate.test;

import static org.junit.Assert.*;
import lsp.violate.Rectangle;
import lsp.violate.Square;

import org.junit.Test;

public class TestRectangle {

	@Test
	public void test() {
		Rectangle rectangle=new Rectangle(20,70);
		boolean actual=shouldNotChangeWidthIfHeightChanges(rectangle);
		assertEquals(true, actual);
	}

	public boolean shouldNotChangeWidthIfHeightChanges(Rectangle r) {
		int beforeChangeHeight=r.getWidth();
		
		r.setHeight(r.getHeight()+20);
		
		int afterChangeHeight=r.getWidth();
		
		return (beforeChangeHeight==afterChangeHeight);
	}
}
