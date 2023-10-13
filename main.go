package main

import "fmt"

func main() {
	fmt.Printf("MaxProfit([]int{1, 4, 2}, 1): %v\n", MaxProfit([]int{20, 30, 27, 24, 23, 28, 33, 38, 34, 35}, 10))
}

func MaxProfit(concours []int, fatigue int) int {
	var ret int
	var plan []bool
	var bordure []bool
	for i := 0; i < len(concours); i++ {
		plan = append(plan, false)
		bordure = append(bordure, false)
	}
	plan[0] = true
	for !compare(bordure, plan) {
		if checker(plan, fatigue) {
			Gain(concours, plan)
			if ret < Gain(concours, plan) {
				ret = Gain(concours, plan)
			}
		}
		plan = Changer(plan)
	}
	return ret
}

func checker(tab []bool, n int) bool {
	check := 0
	for _, v := range tab {
		if v {
			check++
			if check > n {
				return false
			}
		} else {
			check = 0
		}
	}
	return true
}

func Gain(concours []int, planning []bool) int {
	var ret int
	for i, v := range concours {
		if planning[i] {
			ret += v
		}
	}
	return ret
}

func Changer(planning []bool) []bool {
	var ret []bool = planning
	increment := false
	for i := 0; i < len(ret); i++ {
		if increment {
			increment = false
			if ret[i] {
				ret[i] = false
				increment = true
			} else {
				ret[i] = true
			}
		}
		if i == 0 {
			if ret[i] {
				ret[i] = false
				increment = true
			} else {
				ret[i] = true
			}
		}
	}
	return ret
}

func compare(a []bool, b []bool) bool {
	for i, v := range a {
		if v != b[i] {
			return false
		}
	}
	return true
}
