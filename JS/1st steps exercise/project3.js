function deposit(input){
    let money = Number(input[0])
    let time = Number(input[1])
    let interest = Number(input[2]) / 100

    let interestSum = money*interest
    let sum = interestSum*(time/12) + money
    console.log(sum)
}

deposit(["200 ",
"3 ",
"5.7 "])