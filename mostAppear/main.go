package main

type memory struct {
	nbr int
	occ int
}

func MostAppear(tab []int) int {
	var ret int
	var temp []memory
	for _, elem := range tab {
		unknown := -1
		for i, memory := range temp {
			if elem == memory.nbr {
				unknown = i
				break
			}
		}
		if unknown == -1 {
			new := memory{elem, 1}
			temp = append(temp, new)
		} else {
			temp[unknown].occ++
		}
	}
	var max int = 0
	for i, v := range temp {
		if temp[max].occ < v.occ {
			max = i
		}
	}
	ret = temp[max].nbr
	return ret
}

func main() {
	println(MostAppear([]int{1, 3, 3, 2, 2, 2, 3, 3, 1}))
}
