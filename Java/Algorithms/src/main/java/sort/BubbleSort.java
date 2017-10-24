package sort;


import java.util.List;

/**
 * Created by scolia on 2017/10/24
 */
public class BubbleSort<T extends Comparable<T>> {

    /**
     * 冒泡排序, 升序
     *
     * @param list 要排序的集合
     */
    public void sort(List<T> list) {
        boolean hasChange = true;
        int count = 0;
        while (hasChange) {
            hasChange = false;
            for (int i = 0; i < list.size() - 1 - count; i++) {
                if (list.get(i).compareTo(list.get(i + 1)) > 0) {
                    T temp = list.get(i);
                    list.set(i, list.get(i + 1));
                    list.set(i + 1, temp);
                    hasChange = true;
                }
            }
            count++;
        }
    }
}
