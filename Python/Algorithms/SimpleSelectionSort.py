#!/usr/bin/env python
# coding: utf-8
"""
date: 2017/8/13

简单选择排序的实现

"""


class SimpleSelectionSortV1(object):
    """简单选择排序法, 算法复杂度为 O(n^2)"""
    def __init__(self, array, length):
        self.array = array
        self.length = length

    def sort(self):
        """
        升序排序
        :return:
        """
        for i in xrange(0, self.length):
            index = i
            for j in xrange(i + 1, self.length):
                if self.array[index] > self.array[j]:
                    index = j
            if i != index:
                temp = self.array[index]
                self.array[index] = self.array[i]
                self.array[i] = temp

    def sort_desc(self):
        """
        降序排序
        :return:
        """
        for i in xrange(0, self.length):
            index = i
            for j in xrange(i + 1, self.length):
                if self.array[index] < self.array[j]:
                    index = j
            if i != index:
                temp = self.array[index]
                self.array[index] = self.array[i]
                self.array[i] = temp
