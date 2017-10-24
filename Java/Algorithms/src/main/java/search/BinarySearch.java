package search;

import java.util.List;

/**
 * Created by scolia on 2017/10/24
 */
public class BinarySearch<T extends Comparable<T>> {

    /**
     * 二分查找
     *
     * @param list   要查找的集合
     * @param target 要查找的目标
     * @return 返回目标的索引, 若目标不存在, 则返回-1
     */
    public int search(List<T> list, T target) {
        int low = 0;
        int high = list.size();
        while (high >= low) {
            int mid = (low + high) / 2;
            if (target.compareTo(list.get(mid)) > 0) {  // 如果要目标比中值大, 调整最低索引, 让下次查找从右边开始
                low = mid + 1;
            } else if (target.compareTo(list.get(mid)) < 0) { // 如果目标比中值小, 调整最后索引, 让下次查找用左侧起.
                high = mid - 1;
            } else {
                return mid;
            }
        }
        return -1;
    }
}
