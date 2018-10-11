import { Promise } from "q";

export class MathService{
    isPrime(value:number):boolean{
        for(let i=2;i<=value/2;i++){
            if(value%i == 0){
                return false;
            }
        }
        return true;
    }

    isPrimeAsync(value:number){
        let result = Promise((resolve,reject)=>{
            for(let i=2;i<=value/2;i++){
                if(value%i == 0){
                    reject(false);
                    return ;
                }
            }

            resolve(true);
            return;
        });
        return result;
    }
}