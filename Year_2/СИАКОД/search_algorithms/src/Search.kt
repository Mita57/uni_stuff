class Search<T:Number>(private val amount: Int){
//linear search
    private val array = arrayListOf<T>()
    private val element: T = null

    fun <T> linearSearch():Int {
        for(i in 0..this.items.size ){
            if(this.items[i] == this.element){
                return i
            }
        }
        return -1
    }

//binary search

    fun <T:Number> binarySearch():Int{
        items.sort()
        var left = -1
        var right = this.items.size - 1
        while(left < right - 1) {
            val middle = (left + right) / 2
            if((this.items[middle] as Double ) < (this.element as Double)){
                left = middle
            }
            else{
                right = middle
            }
        }
        return  right
    }

    //Интерполяционный поиск

    fun <T:Number>interpolationSearch():Int {
        this.items.sort()
        var left = 0
        var right = this.items.size - 1

        while(((this.items[left] as Double) < (this.element as Double)) && ((this.element as Double) < (this.items[right] as Double))){
            var middle = left + ((this.element - this.items[left] as Double) * (right - left) / (this.items[right] as Double  - this.items[left] as Double)) as Int
            if((this.items[middle] as Double) < (this.element as Double)){
                left = middle++
            }
            else{
                if((this.items[left] as Double) > (this.element as Double)){
                    right = middle--
                }
                else{
                    return middle
                }
            }

            if(this.items[left] === this.element) {
                return  left
            }
            if(this.items[right] === this.element) {
                return right
            }
        }
        return  -1
    }

}