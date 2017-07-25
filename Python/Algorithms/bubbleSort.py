#!/usr/bin/env python
# coding: utf-8
"""
date: 2017/7/25 

冒泡算法的多个实现

"""


class BubbleSortV1(object):
    """最原始的冒泡算法"""
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