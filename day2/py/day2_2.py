#!/usr/bin/env python3
print((constraints:={'red':12,'green':13,'blue':14},re:=__import__('re'),math:=__import__('math'),get_blocks:=lambda x,color: max(int(x) for x in re.findall(f'(\d+?)\s{color}',x)),(aoc_input:=list(filter(lambda x:x,map(lambda x:x.strip(),open('./day2.input').readlines())))),sum([ math.prod([get_blocks(x,k) for k,v in constraints.items()]) for i,x in enumerate(aoc_input,1)]))[-1])