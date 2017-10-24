package sort;

import org.junit.Assert;
import org.junit.Test;

import java.util.Arrays;
import java.util.List;

/**
 * Created by scolia on 2017/10/24
 */
public class BubbleSortTest {
    @Test
    public void sort() throws Exception {
        List<Integer> integers = Arrays.asList(5, 132, 7, 1, 0, 32, 41);
        BubbleSort<Integer> sort = new BubbleSort<>();
        sort.sort(integers);
        Assert.assertEquals(Arrays.asList(0, 1, 5, 7, 32, 41, 132), integers);
    }

}