import { TypesOfSteps } from './TypesOfSteps';

export class StepsOfProposal{
    constructor(public codeStep ?: TypesOfSteps, public dateStep?:Date, public comments ?: string, public results?:boolean){}
}
 
