package sort;

import java.util.List;

/**
 * Created by scolia on 2017/10/25
 */
public class QuickSort<T extends Comparable<T>> {

    /**
     * 交换集合中的a索引和b索引的元素的位置
     *
     * @param list 要求交换的集合
     */
    private void swap(List<T> list, int a, int b) {
        T temp = list.get(a);
        list.set(a, list.get(b));
        list.set(b, temp);
    }

    /**
     * 切分函数
     *
     * 选取一个标杆, 把比标杆小的值放在标杆的左边, 比标杆值大的放在标杆的右边
     * @param list 要进行切分列表
     * @param low 左边的边界索引
     * @param high 右边的边界索引
     * @return 返回标杆所在的索引
     */
    private int partition(List<T> list, int low, int high) {
        T pivot = list.get(low); // 选择一个元素作为标杆
        while (high > low) {
            // 从集合的最后开始, 寻找比标杆小的值
            while (high > low && list.get(high).compareTo(pivot) >= 0){
                high--; // 找到后high就是该元素的索引
            }
            // 交换标杆和比其小的元素的位置, 此时, high的为标杆的位置, low比标杆小的值
            swap(list, low, high);
            // 此时, 从左边开始寻找比标杆大的值,
            // 因为现在low是上面得到的比标杆小的值, 所以索引比如会向右移一位
            while (high > low && list.get(low).compareTo(pivot) <= 0) {
                low++;
            }
            // 找到比标杆大的值后, 交换, 让low再次为标杆的值, 然后重复
            swap(list, low, high);
        }
        return low;
    }

    /**
     * 内部使用的递归函数
     * @param list 要排序的列表
     */
    private void sort(List<T> list, int low, int high) {
        int point; // 切分后的切点
        if (high > low) {
            point = partition(list, low, high);
            sort(list, low, point - 1);
            sort(list, point + 1, high);
        }
    }

    /**
     * 快速排序
     * @param list 要排序的列表
     */
    public void sort(List<T> list) {
        sort(list, 0, list.size() - 1);
    }
}
