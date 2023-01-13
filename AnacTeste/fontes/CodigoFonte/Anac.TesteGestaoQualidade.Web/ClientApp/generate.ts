/* eslint-disable @typescript-eslint/no-var-requires */
/* eslint-disable import/no-extraneous-dependencies */
const OpenAPI = require('openapi-typescript-codegen');

process.env.NODE_TLS_REJECT_UNAUTHORIZED = '0';
OpenAPI.generate({
    input: 'https://localhost:5001/api/docs/v1/swagger.json',
    output: './src/integration',
    useOptions: true,
    useUnionTypes: true,
    httpClient: OpenAPI.HttpClient.AXIOS
});
