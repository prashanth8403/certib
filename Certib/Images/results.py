import matplotlib.pyplot as plt

file = open('result.txt', 'r')

i = 0

msrs = {}
psnrs = {}
for item in file:

    temp = list(map(str.strip, item.split(',')[-3:]))
    print(temp)
    if len(temp) > 2:
        msrs[temp[0].split(':')[1].strip()] = float(
            temp[1].split(':')[1].strip())
        psnrs[temp[0].split(':')[1].strip()] = float(
            temp[2].split(':')[1].strip())

msr_algo = list(msrs.keys())
msr_values = list(msrs.values())

psnr_algo = list(psnrs.keys())
psnr_values = list(psnrs.values())

plt.figure(figsize=(10, 5))
plt.bar(msr_algo, msr_values, color='0.2', width=0.4)
plt.xlabel('Algorithims')
plt.ylabel('MeanSquared error')
plt.title('MSR Values')
plt.show()

plt.figure(figsize=(20, 10))
plt.bar(psnr_algo, psnr_values, color='0.2', width=0.4)
plt.xlabel('Algorithims')
plt.ylabel('Peak signal noise')
plt.title('PSNR Values')
plt.show()
