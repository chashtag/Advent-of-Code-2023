#!/usr/bin/env python3
print(sum([int(''.join(((a:=list(filter(lambda x:x.isdigit(), x)),a[0],a[-1])[1:])))for x in filter(lambda x:x.strip(),open('./day1.input').readlines())]))