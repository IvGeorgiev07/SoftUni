function foodPrice(input){
    let dogfood = input[0]*2.50
    let catFood = input[1]*4
    let totalPrice = dogfood+catFood
    console.log(`${totalPrice} lv,`)
}
foodPrice(["5 ",
"4 "])