package search;

import org.junit.Assert;
import org.junit.Test;

import java.util.Arrays;
import java.util.List;

/**
 * Created by scolia on 2017/10/24
 */
public class BinarySearchTest {
    @Test
    public void search() throws Exception {
        List<Integer> integers = Arrays.asList(5, 132, 7, 1, 0, 32, 41);
        BinarySearch<Integer> search = new BinarySearch<>();
        int result = search.search(integers, 7);
        Assert.assertEquals(2, result);
    }

}