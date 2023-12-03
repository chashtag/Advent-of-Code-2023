#!/usr/bin/env python3
import re
print((constraints:={'red':12,'green':13,'blue':14},re:=__import__('re'),get_blocks:=lambda x,color: all([int(z)<=constraints[color] for z in re.findall(f'(\d+?)\s{color}',x)]),(aoc_input:=list(filter(lambda x:x,map(lambda x:x.strip(),open('./day2.input').readlines())))),sum([i if all([get_blocks(x,k) for k,v in constraints.items()]) else 0 for i,x in enumerate(aoc_input,1)]))[-1])
