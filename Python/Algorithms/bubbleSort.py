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
