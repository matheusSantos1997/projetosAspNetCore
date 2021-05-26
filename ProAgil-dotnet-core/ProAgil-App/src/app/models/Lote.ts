export interface Lote {
    id: number;
    nome: string;
    preco: number;
    dataInicio?: Date;
    dataFim?: Date;
    quantidade: number;
    EventoId: number;
}
