package sort;

import java.util.List;

/**
 * Created by scolia on 2017/10/24
 */
public class StraightInsertionSort<T extends Comparable<T>> {

    /**
     * 简单插入排序, 升序
     * @param list 需要排序的集合
     */
    public void sort(List<T> list) {
        for (int i = 1; i < list.size(); i++) {
            // 如果比已经排序的子序列的最后一位元素小的话, 就要进行插入
            if (list.get(i).compareTo(list.get(i - 1)) < 0) {
                T temp = list.get(i); // 获取要插入的元素
                int j = i - 1;
                // 向后挪动元素
                for (;j >= 0 && list.get(j).compareTo(temp) > 0; j--) {
                    list.set(j + 1, list.get(j));
                }
                list.set(j + 1, temp); // 最后进行插入
            }
        }
    }
}
