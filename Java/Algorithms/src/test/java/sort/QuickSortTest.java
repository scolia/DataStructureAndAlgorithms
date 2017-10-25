package sort;

import org.junit.Assert;
import org.junit.Test;

import java.util.Arrays;
import java.util.List;

/**
 * Created by scolia on 2017/10/25
 */
public class QuickSortTest {
    @Test
    public void sort() throws Exception {
        List<Integer> integers = Arrays.asList(5, 132, 7, 1, 0, 32, 41);
        QuickSort<Integer> sort = new QuickSort<>();
        sort.sort(integers);
        Assert.assertEquals(Arrays.asList(0, 1, 5, 7, 32, 41, 132), integers);
    }

}