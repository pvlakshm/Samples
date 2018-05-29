import org.junit.Before;
import org.junit.Test;

import static org.junit.Assert.*;

public class AddTest {

    Add underTest;

    @Before
    public void setup() {
        underTest = new Add();
    }

    @Test
    public void testAdd_int()
	{
        assertEquals(2, underTest.add_int(1, 1));
    }
}