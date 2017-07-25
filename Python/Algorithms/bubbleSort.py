#!/usr/bin/env python
# coding: utf-8
"""
date: 2017/7/25 

冒泡算法的多个实现

"""


class BubbleSortV1(object):
    """最原始的冒泡算法, 无论是最好最坏的情况下, 其复杂度都是: O(n^2)"""
    def __init__(self, array, length):
        self.array = array
        self.length = length

    def sort(self):
        """
        升序排序
        :return:
        """
        for i in xrange(0, self.length - 1):
            for j in xrange(0, self.length - 1):
                if self.array[j] > self.array[j + 1]:
                    temp = self.array[j]
                    self.array[j] = self.array[j + 1]
                    self.array[j + 1] = temp

    def sort_desc(self):
        """
        降序排序
        :return:
        """
        for i in xrange(0, self.length - 1):
            for j in xrange(0, self.length - 1):
                if self.array[j] < self.array[j + 1]:
                    temp = self.array[j]
                    self.array[j] = self.array[j + 1]
                    self.array[j + 1] = temp


class BubbleSortV2(object):
    """冒泡算法的优化版本, 其复杂度为: n(n-1)/2, 即还是n^2, 但更加高效"""
    def __init__(self, array, length):
        self.array = array
        self.length = length

    def sort(self):
        """
        升序排序
        :return:
        """
        for i in xrange(1, self.length):
            for j in xrange(0, self.length - i):
                if self.array[j] > self.array[j + 1]:
                    temp = self.array[j]
                    self.array[j] = self.array[j + 1]
                    self.array[j + 1] = temp

    def sort_desc(self):
        """
        降序排序
        :return:
        """
        for i in xrange(1, self.length ):
            for j in xrange(0, self.length - i):
                if self.array[j] < self.array[j + 1]:
                    temp = self.array[j]
                    self.array[j] = self.array[j + 1]
                    self.array[j + 1] = temp


class BubbleSortV3(object):
    """冒泡排序的另一种实现思路, 当没有发生交换时, 说明是有序的, 即终止排序, 最好能达到o(n), 一般为O(n^2)"""
    def __init__(self, array, length):
        self.array = array
        self.length = length

    def sort(self):
        """
        升序
        :return:
        """
        count = 0   # 已经冒泡到最后的个数
        while True:
            is_change = False
            for i in xrange(0, self.length - 1 - count):
                if self.array[i] > self.array[i + 1]:
                    temp = self.array[i]
                    self.array[i] = self.array[i + 1]
                    self.array[i + 1] = temp
                    is_change = True
            count += 1  # 每次冒泡完一个, 下次遍历的时候就少交换一个
            if not is_change:
                return

    def sort_desc(self):
        """
        降序
        :return:
        """
        count = 0
        while True:
            is_change = False
            for i in xrange(0, self.length - 1 - count):
                if self.array[i] < self.array[i + 1]:
                    temp = self.array[i]
                    self.array[i] = self.array[i + 1]
                    self.array[i + 1] = temp
                    is_change = True
            count += 1
            if not is_change:
                return
