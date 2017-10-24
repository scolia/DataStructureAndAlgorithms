package sort;

import java.util.List;

/**
 * Created by scolia on 2017/10/24
 */
public class SimpleSelectionSort<T extends Comparable<T>> {

    /**
     * 简单选择排序, 升序
     * @param list 要排序的集合
     */
    public void sort(List<T> list) {
        for (int i = 0; i < list.size(); i++) {
            int min = i; // 假设当前索引就是最小值
            for (int j = i + 1; j < list.size(); j++) {
                if(list.get(j).compareTo(list.get(min)) < 0) {
                    min = j;
                }
            }
            if (min != i) { // 说明找到了最小值, 交换
                T temp = list.get(i);
                list.set(i, list.get(min));
                list.set(min, temp);
            }
        }
    }
}
