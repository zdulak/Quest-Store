import { Artifact } from '@/structures/artifact';

export const artifacts = [
  new Artifact({
    id: 1,
    name: 'Additional consultation (0,5h)',
    description:
      'Duis dignissim, lorem eget interdum hendrerit, erat lectus consequat libero, condimentum rhoncus urna nulla feugiat orci.',
    image: 'iw5fl4fg1rpktt3j7vwt',
    cost: 50,
    quantity: 0
  }),
  new Artifact({
    id: 2,
    name: 'Additional consultation (1h)',
    description:
      'Duis dignissim, lorem eget interdum hendrerit, erat lectus consequat libero, condimentum rhoncus urna nulla feugiat orci.',
    image: 'wfmzkbmjuvv3qrck5zcf',
    cost: 100,
    quantity: 5
  }),
  new Artifact({
    id: 3,
    name: 'Chose topic for next frontal',
    description:
      'Duis dignissim, lorem eget interdum hendrerit, erat lectus consequat libero, condimentum rhoncus urna nulla feugiat orci.',
    image: '',
    cost: 300,
    quantity: 5
  }),
  new Artifact({
    id: 4,
    name: 'Get mentor review for your private project',
    description:
      'Duis dignissim, lorem eget interdum hendrerit, erat lectus consequat libero, condimentum rhoncus urna nulla feugiat orci.',
    image: '',
    cost: 500,
    quantity: 5
  })
];
